using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.UCI307.GOREGHOST3
{
    public class GameSetupMenuManager : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencys")]
        public GameLevelCollection levels;

        #endregion

        #region Private Fields
        public GameLevelData nextLevel;
        #endregion

        #region Monobehaviour Callbacks

        // Start is called before the first frame update
        private void Start()
        {
            UpdateLevelStates();
        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Load dedicated level, used via UI Call
        /// </summary>
        public void LoadTheLevel()
        {
            if (nextLevel == null)
            {
                Debug.LogError("Level not Set!!");
            }
            else
            {
                SceneManager.LoadScene(nextLevel.sceneName);
            }
        }

        public void SetNextLevel(GameLevelData data)
        {
            nextLevel = data;
        }
        #endregion

        #region Private Methods

        private void UpdateLevelStates()
        {
            levels.UpdateLevelStates();
        }

        #endregion
    }
}