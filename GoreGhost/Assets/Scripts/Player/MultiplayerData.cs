using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "New MultiplayerData", menuName = "GoreGhost3/Player/MultiPlayerData")]
    public class MultiplayerData : ScriptableObject, ISerializationCallbackReceiver
    {
        #region PublicFields

        [Header("Configuration")]
        public int PlayerIndex;
        public Color playerColo;
        public CharacterObject playingCharacter;
        public bool initialIsReady;
        public bool initialIsPlaying;

        [NonSerialized]
        public bool isReady;
        [NonSerialized]
        public bool isPlaying;
        
        #endregion

        #region ISerializationCallbackReceiver Implementation

        public void OnAfterDeserialize()
        {
            isReady = initialIsReady;
            isPlaying = initialIsPlaying;
        }

        public void OnBeforeSerialize()
        {
        }
        
        #endregion

        #region Private Fields
        #endregion

    }
}