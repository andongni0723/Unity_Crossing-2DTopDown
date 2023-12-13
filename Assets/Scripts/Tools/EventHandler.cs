using System;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    public static event Action<Vector3> PlayerCrossing;

    public static void CallPlayerCrossing(Vector3 pastPosition)
    {
        PlayerCrossing?.Invoke(pastPosition);
    }

    public static event Action PlayerHurt;

    public static void CallPlayerHurt()
    {
        PlayerHurt?.Invoke();
    }

    public static event Action PlayerDead;

    public static void CallPlayerDead()
    {
        PlayerDead?.Invoke();
    }

    public static event Action<SpawnPositionType> DangerousWallSpawn;

    public static void CallDangerousWallSpawn(SpawnPositionType type)
    {
        DangerousWallSpawn?.Invoke(type);
    }

    public static event Action BossEventPrepare;

    public static void CallBossEventPrepare()
    {
        BossEventPrepare?.Invoke();
    }

    public static event Action BossEventPrepareDone;

    public static void CallBossEventPrepareDone()
    {
        BossEventPrepareDone?.Invoke();
    }

    public static event Action FinalBossDead;

    public static void CallBossDead()
    {
        FinalBossDead?.Invoke();
    }
    
    public static event Action FinalBossDeadEventDone;

    public static void CallFinalBossDeadEventDone()
    {
        FinalBossDeadEventDone?.Invoke();
    }
}
