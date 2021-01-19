using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "New LevelData", menuName = "GoreGhost3/GameLevelData")]
    public class GameLevelData : ScriptableObject
    {
        #region Public Fields

        [Header("Info")]
        public string levelName;
        public string sceneName;
        public bool isUnlocked;

        [Header("Configuration")]
        public float spawnDelay;

        #endregion


    }
}