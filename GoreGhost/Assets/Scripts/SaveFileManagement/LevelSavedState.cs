using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [System.Serializable]
    public class LevelSavedState
    {
        public float lvlID;
        public float lvlState;

        public LevelSavedState(float iD, float state)
        {
            lvlID = iD;
            lvlState = state;
        }
    }
}