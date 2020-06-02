using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Com.UCI307.GOREGHOST3
{
    public class MultiplayerConfigurationManager : MonoBehaviour
    {
        private List<MultiPlayerConfiguration> playerConfigs;

        public static MultiplayerConfigurationManager Instance { get; private set; }

        private void Awake()
        {
            if(Instance != null)
            {
                Debug.Log("MPConfig Manager is trying to create another instance of singleton");
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(Instance);
                playerConfigs = new List<MultiPlayerConfiguration>();
            }
        }

        public void AddPlayer(PlayerInput pi) 
        {
            Debug.Log("calllllleeeddd");
            Debug.Log(pi.playerIndex);
            pi.transform.SetParent(this.transform);
            MultiPlayerConfiguration tmp = new MultiPlayerConfiguration(pi);
            //tmp.se
            this.playerConfigs.Add(tmp);
            
        }

        public List<MultiPlayerConfiguration> GetPlayerInputs()
        {
            return this.playerConfigs;
        }
    }

    public class MultiPlayerConfiguration
    {
        public PlayerInput PlayerInput { get; set; }
        public int PlayerIndex { get; set; }

        public MultiPlayerConfiguration(PlayerInput pi)
        {
            PlayerInput = pi;
            PlayerIndex = pi.playerIndex;
        }
    }
}