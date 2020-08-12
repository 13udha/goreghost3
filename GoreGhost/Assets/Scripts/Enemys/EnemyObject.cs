using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = ("New Enemy Object"), menuName = ("GoreGhost3/GameContent/Enemy Data"))]
    public class EnemyObject : ScriptableObject
    {
        #region Public Fields

        [Header("Config")]
        public string enemyName;
        [TextArea]
        public string description;

        [Header("Attributes")]
        public float health;
        public float movementSpeed;

        [Header("Dependencies")]
        public GameObject prefab;

        #endregion
    }
}
