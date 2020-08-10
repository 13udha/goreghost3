using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    public class SkillTreeSpecManager : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencies")]
        public CharacterValues vals;
        public SkillTreeManagerPower power;
        public SkillTreeManagerDefense defense;
        public SkillTreeManagerMagic magic;
        public Text skillPointDisplay;
        public Text skillPointDisDesc;

        #endregion

        #region Private Fields

        private Color powerColor;
        private Color defenseColor;
        private Color magicColor;
        private CharacterObject co;

        #endregion

        #region MonoB Callbacks
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        #endregion

        #region Public Methods

        public void SetUpDisplay(CharacterObject co)
        {
            this.co = co;
            UpdateSkilltree();
        }


        public void UpdateSkilltree()
        {
            int pts = co.skillPoints;
            if (pts == 0)
            {
                skillPointDisplay.text = "No Skill";
                skillPointDisDesc.text = "Points Available";
            }
            else
            {
                skillPointDisplay.text = pts.ToString();
                skillPointDisDesc.text = "Skill Points Available";
            }
            power.UpdateDisplay();
            defense.UpdateDisplay();
            magic.UpdateDisplay();
        }

        #endregion

        #region Private Methods


        #endregion
    }
}
