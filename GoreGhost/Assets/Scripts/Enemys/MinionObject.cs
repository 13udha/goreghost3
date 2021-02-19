using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = ("New Enemy Object"), menuName = ("GoreGhost3/GameContent/Enemy Data"))]
    public class MinionObject : AEnemyObject
    {
        #region Public Fields

        [Header("Enemy Config")]
        public string enemyName;
        [TextArea]
        public string description;

        [Header("Enemy Attributes")]
        public float health;
        public float movementSpeed;

        [Header("Attacking")]
        public float attackDamage;
        public float attackRange;
        public float minAttackTime;
        public float maxAttackTime;
        public int maxConsecutiveAttacks;

        [Header("Dependencies")]
        public GameObject prefab;

        #endregion
    }
}
