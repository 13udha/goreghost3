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
        public CharacterCollection charCollec;
        public GameLevelCollection lvlCollec;

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
            player.lastSave = DateTime.Now.ToLongTimeString();
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + filePath + fileName + "." + fileEnding;
            FileStream stream = new FileStream(path, FileMode.Create);
            formatter.Serialize(stream, save);
            stream.Close();
            Debug.Log("Saved Player: " + save.playerName + " - " + save.lastSave);
        }

        public void LoadGameState()
        {
            string path = Application.persistentDataPath + filePath + fileName + "." +fileEnding;
            
            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                SaveFile data;
                FileStream stream = new FileStream(path, FileMode.Open);
                data = formatter.Deserialize(stream) as SaveFile;
                stream.Close();
                PlayerFromSave(data);
                Debug.Log("Loaded Player: " + data.playerName + " - " + data.startDate);
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
            Debug.Log(this.name + " -- Loading Player State...");
            player.playerName = save.playerName;
            player.startDate = save.startDate;
            player.lastSave = save.lastSave;
            player.gameState = save.gameState;
            player.money = save.money;

            Debug.Log(this.name + " -- Loading Character States...");
            CharactersFromSave(save.chars);

            Debug.Log(this.name + " -- Loading Level States...");
            LevelStatesFromSave(save.lvlStates);
        }

        private SaveFile PlayerToSave()
        {
            SaveFile save = new SaveFile();

            //Straight Variable Transfers
            Debug.Log(this.name + " -- Saving Player State...");
            save.playerName = player.playerName;
            save.startDate = player.startDate;
            save.lastSave = DateTime.Now.ToLongTimeString();
            save.gameState = player.gameState;
            save.money = player.money;

            Debug.Log(this.name + " -- Saving Character States...");
            save.chars = CharactersToSave();

            Debug.Log(this.name + " -- Saving Level States...");
            save.lvlStates = LevelStatesToSave();

            //return
            return save;
        }

        private List<CharacterSavedState> CharactersToSave()
        {
            List<CharacterSavedState> lst = new List<CharacterSavedState>();

            foreach(CharacterObject co in charCollec.chars)
            {
                lst.Add(co.ToSave());
            }

            return lst;
        }

        private void CharactersFromSave(List<CharacterSavedState> lst)
        {
            for(int i  = 0; i < charCollec.chars.Count; i++)
            {
                charCollec.chars[i].FromSave(lst[i]);
            }
        }

        private List<LevelSavedState> LevelStatesToSave()
        {
            List<LevelSavedState> ret = new List<LevelSavedState>();

            for(int i = 0; i < lvlCollec.levels.Count; i++)
            {
                //Combining Level ID and State to one Vector2 for easy saving
                ret.Add(new LevelSavedState(lvlCollec.levels[i].levelID, lvlCollec.levels[i].levelState));
            }

            return ret;
        }

        private void LevelStatesFromSave(List<LevelSavedState> lst)
        {
            foreach(LevelSavedState v in lst)
            {
                for(int i = 0; i < lvlCollec.levels.Count; i++)
                {
                    if(lvlCollec.levels[i].levelID == v.lvlID)
                    {
                        lvlCollec.levels[i].levelState = v.lvlState;
                    }
                }
            }
        }
        #endregion
    }
}