using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "New MultiplayerData", menuName = "GoreGhost3/Player/MultiPlayerData")]
    public class MultiplayerData : ScriptableObject
    {
        #region PublicFields
        //[Header("Configuration")]
        public int PlayerIndex;
        public bool isReady;
        public bool isPlaying;
        public Color playerColo;
        public CharacterObject playingCharacter;
        #endregion

        #region Private Fields
        #endregion

    }
}