using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    public abstract class ASkillTreeManager : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencies")]
        public CharacterValues vals;
        public SkillTreeSpecManager man;
        public Text skillPointDisplay;
        public Image bgImage;
        public Text skillTreeNameText;
        public Text skillTreeDescText;

        public Button increaseButton;
        public Button decreaseButton;

        #endregion

        #region protected Fields

        protected int skillPointsSpend;
        protected Color skillTreeColor;
        protected string skillTreeName;
        protected string skillTreeDesc;

        protected CharacterObject co;

        #endregion

        #region MonoB Callbacks

        public void Start()
        {
            LoadConfigFromVals();
            bgImage.color = skillTreeColor;
            skillTreeNameText.text = skillTreeName;
            skillTreeDescText.text = skillTreeDesc;
        }

        

        #endregion

        #region Public Methods



        public void UpdateDisplay()
        {
            LoadConfigFromChar();
            skillPointDisplay.text = skillPointsSpend.ToString();
            if (!man.SkillPointsAvailable())
            {
                increaseButton.interactable = false;
            }
            else
            {
                increaseButton.interactable = true;
            }
            if(skillPointsSpend == 0)
            {
                decreaseButton.interactable = false;
            }
            else
            {
                decreaseButton.interactable = true;
            }
        }

        public void SetUpDisplay(CharacterObject co)
        {
            this.co = co;
            UpdateDisplay();
        }

        public void OnIncreaseButton()
        {
            AdjustSkill(true);
            man.UpdateSkilltree();
        }

        public void OnDecreaseButton()
        {
            AdjustSkill(false);
            man.UpdateSkilltree();
        }
        #endregion

        #region Abstract Methods

        /// <summary>
        /// Fill the Variables skilltree color, name and decriptin
        /// </summary>
        protected abstract void LoadConfigFromVals();


        /// <summary>
        /// Read all neccesarry informations to the selected skilltreefrom char
        /// </summary>
        protected abstract void LoadConfigFromChar();

        /// <summary>
        /// increase this skill
        /// </summary>
        protected abstract void AdjustSkill(bool b);
        #endregion

    }
}
