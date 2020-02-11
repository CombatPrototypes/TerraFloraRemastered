using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TypeofEnemy", menuName = "EnemyPreset/New Enemy Preset", order = 1)]
public class SOEnemy : ScriptableObject
{
    public enum EnemyType
    {
        NA,
        Chaser,
        Flyer,
        Turret
    }

    public EnemyType enemyType = EnemyType.NA;

    public float health;
    public float damage;
    public float cooldown;
}
