using Com.UCI307.UCINGEN;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.UCI307.GOREGHOST3
{
    public class LevelManager : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencies")]
        public GameLevelData data;

        [Header("Events")]
        public GameEvent levelStarted;
        public GameEvent introStarted;
        public GameEvent gameplayStarted;
        public GameEvent gameplayEnded;
        public GameEvent outroStarted;
        public GameEvent levelEnded;

        #endregion

        #region Private Fields

        private CompleteCameraController cam;
        private int currentRoom;
        public RoomManager[] rooms;

        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            levelStarted.Raise();

            if (data == null)
                throw new Exception("No Level Data Set on Level Manager");

            //Collect All Rooms in Scene
            rooms = FindObjectsOfType<RoomManager>();

            cam = FindObjectOfType<CompleteCameraController>();
            currentRoom = 0;
            InitialSetUpRooms();

            gameplayStarted.Raise();
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

        private void InitialSetUpRooms()
        {
            // TODO: is this neccesary?
        }


        
        #endregion
    }
}