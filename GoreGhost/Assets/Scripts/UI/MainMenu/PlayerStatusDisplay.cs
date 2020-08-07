using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    public class PlayerStatusDisplay : MonoBehaviour
    {
        #region Public Fields
        [Header("Depnedencys")]
        public PlayerData player;

        [Header("UI Components")]
        public Text nameDisplay;
        public Text creationDate;
        public Text lastSave;
        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            SetUpDisplay();
        }

        private void Awake()
        {
            SetUpDisplay();
        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Public Methods

        public void SetUpDisplay()
        {
            nameDisplay.text = player.playerName;
            creationDate.text = player.startDate;
            lastSave.text = player.lastSave;
        }

        #endregion
    }
}