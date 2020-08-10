using Com.UCI307.UCINGEN;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "New CharacterData", menuName = "GoreGhost3/GameContent/CharacterData")]
    public class CharacterObject : ScriptableObject, ISerializationCallbackReceiver
    {
        #region PublicFields
        [Header("Attributes")]
        public string characterName;
        public float iLevel;
        public float iExperience;
        public float iHealth;
        public float iEnergy;
        public float iMovementSpeed;
        public float iDamage;
        public float iArmor;

        [Header("SkillTree")]
        public int iSkillPoints;
        public int iSkillTree1;
        public int iSkillTree2;
        public int iSkillTree3;

        [Header("Attacks")]
        public float fastAttackRange;

        [Header("Additional Attributes")]
        public Sprite profileImage;
        [TextArea]
        public string description;

        [Header("Configuratio")]
        public bool isUnlocked;
        public GameObject prefab;
        public CharacterValues values;

        [Header("Events")]
        public GameEvent levelUp;
        #endregion

        #region Non Seriaized
        [NonSerialized]
        public float level;
        [NonSerialized]
        public float experience;
        [NonSerialized]
        public float health;
        [NonSerialized]
        public float energy;
        [NonSerialized]
        public float movementSpeed;
        [NonSerialized]
        public int skillPoints;
        [NonSerialized]
        public int skillTree1;
        [NonSerialized]
        public int skillTree2;
        [NonSerialized]
        public int skillTree3;
        #endregion

        #region PublicMethods

        public bool ExperienceGain(float exp)
        {
            float x = experience + exp;
            float remainingExp = x % values.ExpToLevelUp;
            if(x == remainingExp)
            {
                experience = x;
                return false;
            }
            else
            {
                experience = remainingExp;
                level += (x - remainingExp) / values.ExpToLevelUp;
                levelUp.Raise();
                skillPoints++;
                return true;
            }
        }

        public CharacterSavedState ToSave()
        {
            return new CharacterSavedState(level, 
                experience, 
                isUnlocked,
                skillPoints,
                skillTree1,
                skillTree2,
                skillTree3);
        }

        public void FromSave(CharacterSavedState cs)
        {
            this.level = cs.lvl;
            this.experience = cs.exp;
            this.isUnlocked = cs.unlocked;
            skillPoints = cs.skillPoints;
            skillTree1 = cs.skillTree1;
            skillTree2 = cs.skillTree2;
            skillTree3 = cs.skillTree3;
        }
        #endregion

        #region Serialitation Callbacks
        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            level = iLevel;
            experience = iExperience;
            health = iHealth;
            energy = iEnergy;
            movementSpeed = iMovementSpeed;
        }
        #endregion
    }
}