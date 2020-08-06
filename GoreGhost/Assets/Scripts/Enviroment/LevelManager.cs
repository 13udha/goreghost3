using Com.UCI307.UCINGEN;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.UCI307.GOREGHOST3
{
    public class LevelManager : MonoBehaviour
    {
        #region Public Fields
        public GameEvent levelEnded;
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

        public void EndCurrentLevel()
        {
            levelEnded.Raise();
            Time.timeScale = 1;
            SceneManager.LoadScene("MainMenu");
        }

        #endregion

        #region Private Methods
        #endregion
    }
}