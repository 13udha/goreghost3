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
        public int skillPoints;
        public int skillTree1;
        public int skillTree2;
        public int skillTree3;

        public CharacterSavedState(float lvl, float exp, bool unlocked, int skillPoints, int skillTree1, int skillTree2, int skillTree3)
        {
            this.lvl = lvl;
            this.exp = exp;
            this.unlocked = unlocked;
            this.skillPoints = skillPoints;
            this.skillTree1 = skillTree1;
            this.skillTree2 = skillTree2;
            this.skillTree3 = skillTree3;
        }
    }
}
