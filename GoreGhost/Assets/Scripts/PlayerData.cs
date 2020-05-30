using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "New PlayerData", menuName = "GoreGhost3/PlayerData")]
    public class PlayerData : ScriptableObject
    {
        #region Public Fields
        [Header("General Information")]
        public string playerName;
        public string startDate;
        public string lastSave;
        [Tooltip("Tracks how far the Player is in the game \n ______________\n 0 = Its a new game! \n 1 = Completed the tutorial")]
        public int gameState; 
        #endregion
    }
}
