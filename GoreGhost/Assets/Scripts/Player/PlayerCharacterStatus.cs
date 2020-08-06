using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "New PlayerCharacterStatus", menuName = "GoreGhost3/Player/PlayerCharacterStatus")]
    public class PlayerCharacterStatus : ScriptableObject
    {
        #region Public Fields
        [Header("Config")]
        public int index;

        [Header("Stats")]
        public float MaxHP;
        public float CurrentHP;
        public float MaxEnergy;
        public float CurrentEnergy;
        #endregion

        #region Private Fields

        //Dependencies
        public CharacterObject character;

        #endregion

        #region Public Methods

        public void SetCharacter(CharacterObject co)
        {
            this.character = co;
            this.MaxEnergy = co.energy;
            this.CurrentEnergy = co.energy;
            this.MaxHP = co.health;
            this.CurrentHP = co.health;
        }

        public float GetHealthPerc()
        {
            return CurrentHP / MaxHP;
        }

        public float GetEnergyPerc()
        {
            return CurrentEnergy / MaxEnergy;
        }

        public void RecoverHP(float value)
        {
            float x = value + CurrentHP;
            if(x > MaxHP)
            {
                x = MaxHP;
            }
            CurrentHP = x;
        }

        public void RecoverEnergy(float value)
        {
            float x = value + CurrentEnergy;
            if(x > MaxEnergy)
            {
                x = MaxEnergy;
            }
            CurrentEnergy = x;
        }
        #endregion
    }
}