using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

namespace Com.UCI307.GOREGHOST3
{
    public class SpawnPlayerSetupMenu : MonoBehaviour
    {
        #region Public Fields
        public GameObject playerSetUpMenuPrefab;
        public PlayerInput input;
        #endregion

        #region Monobeavhiour Callbacks
        private void Awake()
        {
            var rootMenu = GameObject.Find("MainLayout");
            if(rootMenu != null)
            {
                var menu = Instantiate(playerSetUpMenuPrefab, rootMenu.transform);
                input.uiInputModule = menu.GetComponentInChildren<InputSystemUIInputModule>();
                menu.GetComponent<PlayerJoinMenuManager>().SetPlayerIndex(input.playerIndex);
            }
        }
        #endregion

        #region Public Methods

        #endregion
    }
}