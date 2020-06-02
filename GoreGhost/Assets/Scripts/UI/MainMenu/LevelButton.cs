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
        [Header("UI Components")]
        public Text levelNameDisplay;
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
            manager.nextLevel = data;
        }

        #endregion

        #region Private Methods

        private void SetUpButton()
        {
            levelNameDisplay.text = data.levelName;
        }

        #endregion
    }
}