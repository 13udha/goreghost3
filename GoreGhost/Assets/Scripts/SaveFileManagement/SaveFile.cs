using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [System.Serializable]
    public class SaveFile
    {
        public string playerName;
        public string startDate;
        public string lastSave;
        public int gameState;
        public int money;
        public List<CharacterSavedState> chars;
        public List<LevelSavedState> lvlStates;
    }
}
