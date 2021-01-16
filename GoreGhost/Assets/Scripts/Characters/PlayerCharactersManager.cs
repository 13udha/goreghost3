using Com.UCI307.UCINGEN;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class PlayerCharactersManager : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencies")]
        public MultiplayerCollection players;

        public List<Transform> playerSpawnpoints;

        [Header("Events")]
        public GameEvent playerSpawned;

        #endregion

        #region Monobeheviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            //SpawnPlayers();
        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region PublicMethods

        public void ResetPlayers()
        {
            foreach (MultiplayerData m in players.players)
            {
                m.isPlaying = false;
                m.isReady = false;
            }
        }

        #endregion

        #region Private Methods

        private void SpawnPlayers()
        {
            for (int i = 0; i < players.players.Count; i++)
            {
                if (players.players[i].isReady)
                {
                    GameObject g = GameObject.Instantiate<GameObject>(players.players[i].GetCharacter().prefab, playerSpawnpoints[i]);
                    g.GetComponent<CharacterManager>().status = players.players[i].status;
                    MultiplayerConfigurationManager.Instance.SetCharacterManager(i, g.GetComponent<CharacterManager>());
                    playerSpawned.Raise();
                }
            }
        }


        #endregion

        #region Event Responses
        
        public void OnLevelLoaded()
        {
            SpawnPlayers();
        }

        #endregion
    }
}