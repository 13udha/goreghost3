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
        public Text powerSkillsSpend;
        public Text defenseSkillsSpend;
        public Text magicSkillsSpend;
        public Text skillPoints;
        public SkillTreeSpecManager skillTreeMenu;

        public Image powerBG;
        public Image defenseBG;
        public Image magicBG;

        #endregion

        #region Private Fields

        private CharacterObject co;

        #endregion

        #region MonoB Callbacks
        // Start is called before the first frame update
        void Start()
        {
            skillTreeMenu.gameObject.SetActive(false);
            powerBG.color = charVals.skillTree1Color;
            defenseBG.color = charVals.skillTree2Color;
            magicBG.color = charVals.skillTree3Color;
            
        }

        // Update is called once per frame
        void Update()
        {
        
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
        }

        #endregion
    }
}
