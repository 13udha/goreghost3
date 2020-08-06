﻿using System.Collections.Generic;

namespace Com.UCI307.GOREGHOST3
{
    [System.Serializable]
    public class SaveFile
    {
        public string playerName;
        public string startDate;
        public string lastSave;
        public int gameState;
        public List<CharacterSavedState> chars;
    }
}
