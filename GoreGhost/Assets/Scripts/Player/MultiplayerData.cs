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
        public Color playerColo;
        public CharacterObject playingCharacter;
        #endregion

        #region Private Fields
        [System.NonSerialized]
        private PlayerInput input;
        #endregion

        #region Getters/Setters
        public PlayerInput GetPlayerInput()
        {
            return input;
        }

        public void SetPlayerInput(PlayerInput input)
        {
            this.input = input;
            Debug.Log(this.input.playerIndex);
        }
        #endregion

    }
}