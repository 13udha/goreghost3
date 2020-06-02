using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "CharacterCollection", menuName = "GoreGhost3/GameContent/CharacterCollection")]
    public class CharacterCollection : ScriptableObject
    {
        public List<CharacterObject> chars;
    }
}