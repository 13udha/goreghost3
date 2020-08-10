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
        private int skillPoints;


        private int revertSP;
        private int revertST1;
        private int revertST2;
        private int revertST3;
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

        private void OnEnable()
        {
            
        }
        #endregion

        #region Public Methods

        public void ConfirmButton()
        {
            FindObjectOfType<CharacterDetailDisplay>().SetUpCharacter(co);
            this.gameObject.SetActive(false);
        }

        public void CancelButton()
        {
            co.skillPoints = revertSP;
            co.skillTree1 = revertST1;
            co.skillTree2 = revertST2;
            co.skillTree3 = revertST3;
            FindObjectOfType<CharacterDetailDisplay>().SetUpCharacter(co);
            this.gameObject.SetActive(false);
        }

        public void SetUpDisplay(CharacterObject co)
        {
            this.co = co;
            power.SetUpDisplay(co);
            defense.SetUpDisplay(co);
            magic.SetUpDisplay(co);
            SaveCharState();
            UpdateSkilltree();
        }


        public void UpdateSkilltree()
        {
            skillPoints = co.skillPoints;
            if (skillPoints == 0)
            {
                skillPointDisplay.text = "No Skill";
                skillPointDisDesc.text = "Points Available";
            }
            else
            {
                skillPointDisplay.text = skillPoints.ToString();
                skillPointDisDesc.text = "Skill Points Available";
            }
            power.UpdateDisplay();
            defense.UpdateDisplay();
            magic.UpdateDisplay();
        }

        public bool SkillPointsAvailable()
        {
            if (skillPoints > 0)
                return true;

            return false;
        }

        #endregion

        #region Private Methods

        private void SaveCharState()
        {
            revertSP = co.skillPoints;
            revertST1 = co.skillTree1;
            revertST2 = co.skillTree2;
            revertST3 = co.skillTree3;
        }

        #endregion
    }
}
