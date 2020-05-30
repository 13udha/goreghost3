using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    public class LoadGameMenu : MonoBehaviour
    {
        #region Public Fields
        [Header("Dependencys")]
        public SaveSystem savesys;

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

        public void LoadGame()
        {
            savesys.LoadGameState();
        }

        #endregion
    }
}