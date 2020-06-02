﻿using System.Collections;
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

        #endregion

        #region Monobeheviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            SpawnPlayers();
        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Private Methods

        private void SpawnPlayers()
        {
            for (int i = 0; i < players.players.Count; i++)
            {
                if (players.players[i].isReady)
                {
                    GameObject g = GameObject.Instantiate<GameObject>(players.players[i].playingCharacter.prefab, playerSpawnpoints[i]);
                    MultiplayerConfigurationManager.Instance.SetCharacterManager(i, g.GetComponent<CharacterManager>());
                }
            }
        }

        #endregion
    }
}