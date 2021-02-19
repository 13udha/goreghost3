using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    public class NewGameMenu : MonoBehaviour
    {
        #region Public Fields
        [Header("Dependencys")]
        public PlayerData player;
        public SaveSystem savesys;
        public Text nameInput;
        public GameLevelCollection levels;

        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Public Methods
        
        public void StartNewGame()
        {
            if(nameInput.text.Length < 3)
            {
                Debug.LogWarning(this.ToString() +" says: Please enter a Name longer than three characters!");
                return;
            }
            else
            {
                player.playerName = nameInput.text;
                player.startDate = DateTime.Now.ToLongTimeString();
                levels.ResetProgress();
                player.lastSave = player.startDate;
                savesys.SaveGameState();
            }
            
        }

        #endregion
    }
}