using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class SaveMenuManager : MonoBehaviour
    {
        #region Public Fields
        public SaveSystem saveSys;
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
        
        public void SaveGameButton()
        {
            saveSys.SaveGameState();
        }
        #endregion
    }
}