using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Com.UCI307.GOREGHOST3
{

    public class MultiplayerSetupMenuManager : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencys")]
        public MultiplayerCollection players;
        public PlayerInputManager pim;
        public GameObject charSelectionMenuPrefab;

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
            csm.transform.SetParent(this.transform);
        }

        #endregion
    }
}