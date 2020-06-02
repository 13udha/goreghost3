using Com.UCI307.UCINGEN;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;

namespace Com.UCI307.GOREGHOST3
{
    /// <summary>
    /// Singleton der Über die Level persisted und dafür sorgt das der Zugriff auf die Input Manager der Spieler verfügbar ist.
    /// </summary>
    public class MultiplayerConfigurationManager : MonoBehaviour
    {
        #region Public Fields
        public List<MultiplayerControlManager> playerControls;

        [Header("Events")]
        public GameEvent playerJoined;
        #endregion

        #region Private Fields
        private List<MultiPlayerConfiguration> playerConfigs;
        #endregion

        #region Singleton Setup
        public static MultiplayerConfigurationManager Instance { get; private set; }

        /// <summary>
        /// Baut den Singelton auf
        /// </summary>
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
        #endregion

        #region Public Methods

        /// <summary>
        /// Fügt den Controller eines einzigen Spielers hinzu. 
        /// Erstellt eine Multiplayer Configuration. Diese ist ein reiner Datencontainer.
        /// </summary>
        /// <param name="pi">Der Playerinput des Gewünschten Spielers</param>
        public void AddPlayer(PlayerInput pi) 
        {
            pi.transform.SetParent(this.transform);
            MultiPlayerConfiguration tmp = new MultiPlayerConfiguration(pi);
            //tmp.se
            this.playerConfigs.Add(tmp);
            playerJoined.Raise();
            
        }

        public List<MultiPlayerConfiguration> GetPlayerInputs()
        {
            return this.playerConfigs;
        }

        /// <summary>
        /// Weist einem MultiplayerControlManager in der eigenen Liste einen Character Manager zu. Dies muss getan werden damit der Character in einem Level angesteuert werden kann.
        /// </summary>
        /// <param name="i">Index des gewünschten Spielers</param>
        /// <param name="c">Character Manager des Gewählten Spielers</param>
        public void SetCharacterManager(int i, CharacterManager c)
        {
            foreach (MultiplayerControlManager pc in playerControls)
            {
              if(pc.playerInput.playerIndex == i)
                {
                    pc.characterManager = c;
                    return;
                }
            }
        }

        public void DestroyThis()
        {
            GameObject.Destroy(this.gameObject);
        }
        #endregion
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