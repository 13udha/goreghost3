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
        public float experience;
        public float health;
        public float energy;
        public float movementSpeed;

        [Header("Attacks")]
        public float fastAttackRange;

        [Header("Additional Attributes")]
        public Sprite profileImage;
        [TextArea]
        public string description;

        [Header("Configuratio")]
        public bool isUnlocked;
        public GameObject prefab;
        #endregion

        #region PublicMethods

        public float GetLevel()
        {
            return (Mathf.Round(experience / 1000))+1;
        }

        #endregion
    }
}