using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class SkillTreeSpecManager : MonoBehaviour
    {
        #region Public Fields

        public CharacterValues vals;
        public SkillTreeManagerPower power;
        public SkillTreeManagerDefense defense;
        public SkillTreeManagerMagic magic;

        #endregion

        #region Private Fields

        private Color powerColor;
        private Color defenseColor;
        private Color magicColor;

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
        }

        

        #endregion
    }
}
