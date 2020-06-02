using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "New CharacterData", menuName = "GoreGhost3/GameContent/CharacterData")]
    public class CharacterObject : ScriptableObject
    {
        #region PublicFields
        [Header("Attributes")]
        public string characterName;
        public float health;
        public float energy;

        [Header("Additional Attributes")]
        public Sprite profileImage;
        [TextArea]
        public string description;

        [Header("Configuratio")]
        public bool isUnlocked;
        public GameObject prefab;
        #endregion
    }
}