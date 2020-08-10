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
        public Text skillPointDisplay;
        public Image bgImage;
        public Text skillTreeNameText;
        public Text skillTreeDescText;

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
            Debug.Log("DDDDDDDDDDDDDDD");
            LoadConfigFromVals();
            bgImage.color = skillTreeColor;
            skillTreeNameText.text = skillTreeName;
            skillTreeDescText.text = skillTreeDesc;
        }

        #endregion

        #region Public Methods

        public void SetUpDisplay(CharacterObject co)
        {
            this.co = co;
            LoadConfigFromChar();

        }

        public void OnIncreaseButton()
        {

        }

        public void OnDecreaseButton()
        {

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

        #endregion

    }
}
