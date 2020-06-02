using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{

    public class MultiplayerSetupMenuManager : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencys")]
        public MultiplayerCollection players;
        public PlayerInputManager pim;
        public GameObject charSelectionMenuPrefab;
        public Button startLevelButton;

        #endregion

        #region Private Fields
        
        List<CharSelectionPanelManager> panels;
        
        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Awake()
        {
            panels = new List<CharSelectionPanelManager>();
            
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnEnable()
        {
            //Debug.Log("Manager enabled");
            pim.EnableJoining();
            startLevelButton.interactable = false;
        }
        #endregion

        #region Public Methods

        public void RegisterPanel(CharSelectionPanelManager panel)
        {
            this.panels.Add(panel);
            //panel.player = (players.players[panel.GetComponent<PlayerInput>().playerIndex]);
        }

        public void SetUpPlayer()
        {
            GameObject csm = GameObject.Instantiate<GameObject>(charSelectionMenuPrefab);
            CharSelectionPanelManager cspm = csm.GetComponent<CharSelectionPanelManager>();
            int index = (MultiplayerConfigurationManager.Instance.GetPlayerInputs().Count - 1);
            cspm.SetPlayerIndex(index);
            cspm.player = players.players[index];
            csm.transform.SetParent(this.transform);
            players.players[index].isPlaying = true;
        }

        public void CheckIfAllPlayersReady()
        {
            bool b = true;
            foreach(MultiplayerData player in players.players)
            {
                if((player.isPlaying && !player.isReady))
                {
                    b = false;
                }
            }
            startLevelButton.interactable = b;
        }

        #endregion
    }
}