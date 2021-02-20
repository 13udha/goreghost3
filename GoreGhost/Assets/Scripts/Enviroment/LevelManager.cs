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
        public AudioSource audioPlayer;

        public SoundSetting soundSettings;

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
            playMusic();
            if (data == null)
                throw new Exception("No Level Data Set on Level Manager");

            
            InitialSetUpRooms();

            gameplayStarted.Raise();
        }


        void playMusic()
        {
            audioPlayer.clip = data.DefaultMusic; 
            audioPlayer.volume= soundSettings.AmbientSoundVolume;
            audioPlayer.Play();

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
            //Collect All Rooms in Scene
            rooms = FindObjectsOfType<RoomManager>();

            cam = FindObjectOfType<CompleteCameraController>();
            currentRoom = 1;

            foreach (RoomManager r in rooms)
            {
                r.LayRoomDormant();
                r.gameObject.SetActive(false);
            }

            RoomSetup(currentRoom);
        }
        
        private void RoomSetup(int x)
        {
            foreach (RoomManager r in rooms)
            {
                if(r.roomSeqNr == x)
                {
                    Debug.Log("room " + x + " activated");
                    r.gameObject.SetActive(true);
                    r.WakeUpRoom();
                }
            }
        }

        private void NextRoom()
        {
            if(currentRoom >= rooms.Length)
            {
                AllRoomsCleared();
            }
            else
            {
                Debug.Log(Time.time + "Next Room Called: Switching from Room " + currentRoom + " to Room " + (currentRoom + 1) );
                rooms[currentRoom].LayRoomDormant();
                Debug.Log("----------------- SeqNr is:" + rooms[currentRoom].roomSeqNr + "----- N is" + (currentRoom+1));
                GetRoom(currentRoom).gameObject.SetActive(false);
                currentRoom++;
                RoomSetup(currentRoom);
            }
            
        }

        private void AllRoomsCleared()
        {
            data.levelState = 2;
            gameplayEnded.Raise();
            EndCurrentLevel();
        }

        private RoomManager GetRoom(int n)
        {
            foreach ( RoomManager r in rooms)
            {
                if(r.roomSeqNr == n)
                {
                    return r;
                }
            }
            throw new Exception();
        }
        #endregion

        #region Event Responses

        public void OnRoomClear()
        {
            NextRoom();
        }

        #endregion
    }
}