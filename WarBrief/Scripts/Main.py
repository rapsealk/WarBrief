API_VERSION = 'API_v1.0'
MOD_NAME = 'RLMod'

import time         # noqa: E402

cbhandle = None
CALLBACK_TICK = 1

cache = {
    "player": {
        "health": 15100,
        "maxHealth": 15100,
        "yaw": 0,
        "speed": 0
    },
    "enemy": {
        "health": 15100,
        "maxHealth": 15100,
        "yaw": 0,
        "isVisible": False,
        "isShipVisible": False
    }
}

player_id = -1
player_ship_id = -1
player_team_id = -1
X_OFFSET = 2.35619449615

PI = 3.141592653589793
KNOT_UNIT = 2.619387861613757


def _update_player():
    global player_id, player_team_id, player_ship_id
    info = battle.getSelfPlayerInfo()   # noqa: F821
    player_id = info["id"]
    player_team_id = info["teamId"]
    player_ship_id = info["shipId"]

    data = info["shipGameData"]
    try:
        knot = data["speed"] / KNOT_UNIT
    except KeyError:
        knot = 0
    args = (data["health"], data["maxHealth"], data["yaw"], knot)
    with open('player.log', 'w') as f:
        f.write('{"Health": %s, "MaxHealth": %s, "Yaw": %s, "Knot": %s}' % args)


def callback(*args, **kwargs):
    global player_id
    global cache
    _update_player()

    with open('players.log', 'w') as f:
        # isOwn
        for player in battle.getPlayersInfo().values():     # noqa: F821
            f.write('%s\n' % player)

    players = [player for player in battle.getPlayersInfo().values() if player["id"] != player_id]  # noqa: F821
    for player in players:

        id_ = player["id"]
        team_id = player["teamId"]
        info = battle.getPlayerInfo(id_)    # noqa: F821
        data = info["shipGameData"]
        # vehicle_param = info["vehicleParams"]

        if player_team_id == team_id:
            pass
            """
            # Ally
            args = (data["health"], data["maxHealth"], data["yaw"])
            with open('ally.log', 'w') as f:
                f.write('{"health": %d, "maxHealth": %d, "yaw": %f}' % args)
            with open('ally-data-%d.log' % id_, 'w') as f:
                f.write(str(info))
            """
        else:
            # Enemy
            if data["isVisible"]:
                cache["enemy"] = data
            else:
                data = cache["enemy"]
            args = (data["health"], data["maxHealth"], data["yaw"], data["isVisible"], data["isShipVisible"])
            with open('enemy.log', 'w') as f:
                f.write('{"Health": %s, "MaxHealth": %s, "Yaw": %s, "IsVisible": %s, "IsShipVisible": %s}' % args)


def on_shell_info(*args, **kwargs):
    """
    victimID - shipID an identifier of the attacked ship
    shooterID - shipID an identifier of the attacking ship
    ammoID - a shell type
    matID - a type of material that was hit
    shootID - ID, a shot identifier
    booleans - a type of damage after taking a hit (this value has a bit mask):
        our ship was damaged
        armor penetration
        damage under water
        the ship is destroyed
        a shell went through the ship
        a ricochet off the armor
        splash damage
        main caliber guns are destroyed
        torpedo launchers are destroyed
        secondary battery is destroyed
    damage - the amount of dealt damage
    shotPosition - a tuple with coordinates of the point of impact
    yaw - yaw of the shell, its angle of impact
    hlinfo - a tuple with the information about the salvo (list with damage info, salvo ID or salvo number)
    """
    ammo_id = args[2]
    ammo = battle.getAmmoParams(ammo_id)    # noqa: F821
    with open('ammo.log', 'w') as f:
        f.write(str(ammo))

    victim, shooter, damage = args[0], args[1], args[6]
    args_ = (time.time(), player_ship_id, victim, shooter, damage)
    shellinfo_log = '{"timestamp": %s, "player_ship_id": %d, "victim": %d, "shooter": %d, "damage": %d}\n' % args_
    with open('shell_info.log', 'w') as f:
        f.write(shellinfo_log)

    """
    booleans = args[5]
    booleans_ = []
    while booleans:
        booleans_.append(booleans % 2)
        booleans = booleans >> 1
    with open('booleans-%d.log' % int(time.time() * 1000), 'w') as f:
        f.write('{"booleans": %s}' % booleans_)
    """


def got_ribbon(*args, **kwargs):
    ribbons = list(args)
    with open('ribbon-%s.log' % time.time(), 'w') as f:
        f.write('{"Ids": %s}' % ribbons)


def battle_start(*args, **kwargs):
    global cbhandle

    _update_player()
    # Initializer
    cache["enemy"] = {
        "health": 15100,
        "maxHealth": 15100,
        "yaw": 0,
        "isVisible": False,
        "isShipVisible": False
    }

    cbhandle = callbacks.callback(CALLBACK_TICK, callback)  # noqa: F821
    with open('battle_start.log', 'w') as f:
        f.write('{"Status": 1, "Result": 0}')


def battle_end(*args, **kwargs):
    global cbhandle
    callbacks.cancel(cbhandle)  # noqa: F821
    with open('battle_end.log', 'w') as f:
        f.write('{"Status": 0, "Result": %d}' % args[0])


def battle_quit(*args, **kwargs):
    global cbhandle
    callbacks.cancel(cbhandle)  # noqa: F821
    with open('battle_quit.log', 'w') as f:
        f.write('{"Status": -1, "Result": 0}')


events.onReceiveShellInfo(on_shell_info)    # noqa: F821
events.onGotRibbon(got_ribbon)              # noqa: F821
events.onBattleStart(battle_start)          # noqa: F821
events.onBattleEnd(battle_end)              # noqa: F821
events.onBattleQuit(battle_quit)            # noqa: F821
