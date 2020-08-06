using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class GameHudManager : MonoBehaviour
    {
        #region Public Fields
        public GameObject pauseMenu;
        #endregion

        #region Private Fields
        private bool gamePaused = false;
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

        #region Button Methods

        public void OnResume()
        {
            OnGameUnpaused();
        }

        public void OnExit()
        {

        }

        #endregion

        #region Event Responses

        public void OnGamePaused()
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
            gamePaused = true;
        }

        public void OnGameUnpaused()
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
            gamePaused = false;
        }

        #endregion
    }
}
