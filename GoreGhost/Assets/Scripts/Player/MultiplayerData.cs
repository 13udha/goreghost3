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
        public bool initialIsReady;
        public bool initialIsPlaying;

        [Header("Dependencies")]
        public PlayerCharacterStatus status;

        [NonSerialized]
        public bool isReady;
        [NonSerialized]
        public bool isPlaying;

        #endregion

        #region Private Fields
        private CharacterObject playingCharacter;
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
        
        public void SetCharacter(CharacterObject co)
        {
            this.playingCharacter = co;
            status.SetCharacter(co);
        }

        public CharacterObject GetCharacter()
        {
            return playingCharacter;
        }
        #endregion

        #region Private Fields
        #endregion

    }
}