using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.UCI307.GOREGHOST3
{
    public class MenuManager : MonoBehaviour
    {
        #region Public Fields

        public GameObject[] menus;
        public int startingMenu;

        #endregion

        #region PrivateFields

        private int lastMenu;
        private int currentMenu;

        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            SetMenuByID(startingMenu);
            currentMenu = 0;
            lastMenu = 0;
        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region PublicMethods

        public void SetMenuByID(int i)
        {
            lastMenu = currentMenu;
            foreach (GameObject g in menus)
            {
                g.SetActive(false);
            }
            currentMenu = i;
            menus[i].SetActive(true);
        }

        public void ExitApplication()
        {
            Application.Quit();
        }

        public void Back()
        {
            SetMenuByID(lastMenu);
        }

        public void LoadScene(string s)
        {
            SceneManager.LoadScene(s);
        }
        #endregion
    }
}