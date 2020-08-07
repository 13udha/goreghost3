using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [System.Serializable]
    public class CharacterSavedState
    {
        public float lvl;
        public float exp;
        public bool unlocked;

        public CharacterSavedState(float l, float e, bool u)
        {
            lvl = l;
            exp = e;
            unlocked = u;
        }
    }
}
