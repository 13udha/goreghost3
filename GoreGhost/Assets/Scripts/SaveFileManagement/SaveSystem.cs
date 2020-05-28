using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "SaveSystem", menuName = "GoreGhost3/SaveManagement/SaveSystem")]
    public class SaveSystem : ScriptableObject
    {
        #region Public Fields
        [Header("Dependencys")]
        public PlayerData player;

        [Header("Save File Configuration")]
        [Tooltip("Defines where the save file will be placed")]
        public string filePath;
        [Tooltip("Defines what the name of the save file will be")]
        public string fileName;
        [Tooltip("Defines the file ending of the save file")]
        public string fileEnding;
        #endregion

        
        #region Public Methods

        public void SaveGameState()
        {
            SaveFile save = PlayerToSave();
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + filePath + fileName + "." + fileEnding;
            FileStream stream = new FileStream(path, FileMode.Create);
            formatter.Serialize(stream, save);
            stream.Close();
        }

        public void LoadGameState()
        {
            string path = Application.persistentDataPath + filePath + fileName + fileEnding;
            
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                SaveFile data;
                FileStream stream = new FileStream(path, FileMode.Open);
                data = formatter.Deserialize(stream) as SaveFile;
                stream.Close();
                PlayerFromSave(data);
                Debug.Log(data.playerName + " - " + data.startDate);
            }
            else
            {
                Debug.LogError("No Save File found in " + path);
                return;
            }
            
        }

        #endregion

        #region Private Methods

        private void PlayerFromSave(SaveFile save)
        {
            //Straight Variable Transfers
            player.playerName = save.playerName;
            player.startDate = save.startDate;
            player.lastSave = save.lastSave;
            player.newGame = save.newGame;
        }

        private SaveFile PlayerToSave()
        {
            SaveFile save = new SaveFile();

            //Straight Variable Transfers
            save.playerName = player.playerName;
            save.startDate = player.startDate;
            save.lastSave = DateTime.Now.ToLongDateString();
            save.newGame = player.newGame;

            //return
            return save;
        }

        #endregion
    }
}