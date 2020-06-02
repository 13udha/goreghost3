using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    public class PlayerJoinMenuManager : MonoBehaviour
    {
        #region Public Fields

        public PlayerConfigurationSystem mpSys;
        public int playerIndex;

        public Text titleText;
        public GameObject readyPanel;
        public GameObject menuPanel;
        public Button readyButton;

        #endregion

        #region Debug Fields
        public Color[] colors;
        
        #endregion

        #region Public Fields

        private float ignoreInputTime = 1.5f;
        private bool inputEnabled;

        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(Time.time > ignoreInputTime)
            {
                inputEnabled = true;
            }
        }
        #endregion

        #region Public Methods

        public void SetPlayerIndex(int pi)
        {
            playerIndex = pi;
            titleText.text = "Player " + pi+1;
            ignoreInputTime = Time.time + ignoreInputTime;
        }

        public void OnPlayerJoined(PlayerInput pi)
        {
            mpSys.parent = this.gameObject;
            mpSys.HandlePlayerJoin(pi);
        }

        public void SetPlayerColor(int color)
        {
            if (!inputEnabled) { return; }
            mpSys.SetPlayerColor(playerIndex, colors[color]);
            readyPanel.SetActive(true);
            readyButton.Select();
            menuPanel.SetActive(false);
        }

        public void ReadyPlayer()
        {
            if (!inputEnabled) { return; }
            mpSys.ReadyPlayer(playerIndex);
            readyButton.gameObject.SetActive(true);
        }
        #endregion
    }
}