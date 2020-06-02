using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "PlayerConfigurationSystem", menuName = "GoreGhost3/Multiplayer/PlayerConfigurationManager")]
    public class PlayerConfigurationSystem : ScriptableObject
    {
        #region Public Fields
        public List<MultiplayerData> playerConfigs;
        public GameObject parent;
        #endregion

        [SerializeField]
        private int MaxPlayers = 2;

        #region Public Methods

        

        public void SetPlayerColor(int index, Color color)
        {
            playerConfigs[index].playerColo = color;
        }

        public void ReadyPlayer(int index)
        {
            playerConfigs[index].isReady = true;
            if(playerConfigs.Count == MaxPlayers && playerConfigs.All(playerConfigs => playerConfigs.isReady == true))
            {
                SceneManager.LoadScene("Level_MPDebug");
            }
        }

        #endregion
    }
}