using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3 {
    public class LevelButton : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencys")]
        public GameLevelData data;
        public GameSetupMenuManager manager;
        public Button button;
        public Text levelNameDisplay;
        public Image cleared;
        
        #endregion

        #region MonoBehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            if(data == null)
            {
                Debug.LogError(this.ToString() + " Level Load Button has not been given a Level Data Object!");
            }
            else
            {
                SetUpButton();
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Public Methods

        public void SetLevel()
        {
            Debug.Log("-----------------------------------------");
            manager.SetNextLevel(data);
        }

        public void OnLevelStatesUpdated()
        {
            SetUpButton();
        }

        #endregion

        #region Private Methods

        private void SetUpButton()
        {
            switch (data.levelState)
            {
                case 0: //lvl locked
                    button.interactable = false;
                    cleared.gameObject.SetActive(false);
                    break;
                case 1: //lvl unlocked
                    button.interactable = true;
                    cleared.gameObject.SetActive(false);
                    break;
                case 2: //lvl completed
                    button.interactable = true;
                    cleared.gameObject.SetActive(true);
                    break;
                default:
                    break;
            }

            levelNameDisplay.text = data.levelName;
        }

        #endregion
    }
}