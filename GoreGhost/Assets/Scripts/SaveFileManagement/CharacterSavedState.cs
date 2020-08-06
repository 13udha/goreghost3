﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [System.Serializable]
    public class CharacterSavedState
    {
        public float lvl;
        public float exp;

        public CharacterSavedState(float l, float e)
        {
            lvl = l;
            exp = e;
        }
    }
}
