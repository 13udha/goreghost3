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
        public Text textDisplay;

        
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

        private void OnEnable()
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
            textDisplay.text = "PLAYER STATUS";
            textDisplay.text += "\n Name: " + player.playerName;
            textDisplay.text += "\n Startin Date: " + player.startDate;
            textDisplay.text += "\n Last Save: " + player.lastSave;
        }

        #endregion
    }
}