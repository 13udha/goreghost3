using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "CharacterValues", menuName = "GoreGhost3/GameContent/CharacterValues")]
    public class CharacterValues : ScriptableObject
    {
        
        public float ExpToLevelUp;
        public float MaximumLevel;

        [Header("SkillTrees")]
        public string skillTree1Name;
        public Color skillTree1Color;
        [TextArea]
        public string SkillTree1Description;

        public string skillTree2Name;
        public Color skillTree2Color;
        [TextArea]
        public string SkillTree2Description;

        public string skillTree3Name;
        public Color skillTree3Color;
        [TextArea]
        public string SkillTree3Description;


    }
}
