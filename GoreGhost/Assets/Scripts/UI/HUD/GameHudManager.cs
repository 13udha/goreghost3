using Com.UCI307.UCINGEN;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class GameHudManager : MonoBehaviour
    {
        #region Public Fields
        [Header("Dependencies")]
        public GameObject pauseMenu;

        [Header("Events")]
        public GameEvent levelEnded;
        public GameEvent exitButton;
        #endregion

        #region Private Fields
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
            levelEnded.Raise();
        }

        #endregion

        #region Event Responses

        public void ExitLevelFromMenu()
        {
            exitButton.Raise();
        }

        public void OnGamePaused()
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }

        public void OnGameUnpaused()
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }

        #endregion
    }
}
