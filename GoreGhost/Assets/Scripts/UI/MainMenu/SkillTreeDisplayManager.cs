using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    /// <summary>
    /// Managed das darstellen de Skill trees im Charakter Detail Screen. 
    /// </summary>
    public class SkillTreeDisplayManager : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencies")]
        public CharacterValues charVals;
        public Text skillSpend1;
        public Text skillsSpend2;
        public Text skillsSpend3;
        public Text skillPoints;
        public SkillTreeSpecManager skillTreeMenu;

        public Image skillBG1;
        public Image skillBG2;
        public Image skillBG3;

        #endregion

        #region Private Fields

        private CharacterObject co;

        #endregion

        #region MonoB Callbacks
        // Start is called before the first frame update
        void Start()
        {
            skillTreeMenu.gameObject.SetActive(false);
            skillBG1.color = charVals.skillTree1Color;
            skillBG2.color = charVals.skillTree2Color;
            skillBG3.color = charVals.skillTree3Color;
            
            
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnEnable()
        {
            if(co != null)
                UpdateDisplay();
        }
        #endregion

        #region Public Methods

        public void OpenSkilltree()
        {
            skillTreeMenu.gameObject.SetActive(true);
            skillTreeMenu.SetUpDisplay(co);
        }

        internal void SetUpDisplay(CharacterObject co)
        {
            this.co = co;
            skillTreeMenu.gameObject.SetActive(false);
            UpdateDisplay();
        }

        #endregion

        #region Private Methods
        
        private void UpdateDisplay()
        {
            if(co != null)
            {
                skillPoints.text = co.skillPoints.ToString();
                skillSpend1.text = co.skillTree1.ToString();
                skillsSpend2.text = co.skillTree2.ToString();
                skillsSpend3.text = co.skillTree3.ToString();
            }

        }

        #endregion
    }
}
