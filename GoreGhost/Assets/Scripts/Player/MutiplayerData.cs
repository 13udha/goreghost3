using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "New MultiplayerData", menuName = "GoreGhost3/Player/MultiPlayerData")]
    public class MutiplayerData : ScriptableObject
    {
        #region PublicFields
        [Header("Configuration")]
        public bool isPlaying;

        [Tooltip("Differentiates between the four players")]
        public int playerID;
        public Color playerColo;
        #endregion
    }
}