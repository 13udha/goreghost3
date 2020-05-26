using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class MenuManager : MonoBehaviour
    {
        #region Public Fields

        public GameObject[] menus;
        public int startingMenu;

        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            SetMenuByID(startingMenu);
        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region PublicMethods

        public void SetMenuByID(int i)
        {
            foreach (GameObject g in menus)
            {
                g.SetActive(false);
            }
            menus[i].SetActive(true);
        }

        public void ExitApplication()
        {
            Application.Quit();
        }
        #endregion
    }
}