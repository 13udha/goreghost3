using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.UCI307.GOREGHOST3
{
    public class GameSetupMenuManager : MonoBehaviour
    {
        #region private Fields
        public GameLevelData nextLevel;
        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Public Void
        public void LoadTheLevel()
        {
            if(nextLevel == null)
            {
                Debug.LogError("Level not Set!!");
            }
            else
            {
                SceneManager.LoadScene(nextLevel.sceneName);
            }
        }
        #endregion
    }
}