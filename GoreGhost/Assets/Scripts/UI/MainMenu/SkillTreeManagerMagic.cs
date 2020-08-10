using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class SkillTreeManagerMagic : ASkillTreeManager
    {

        #region MonoB Callbacks
        // Start is called before the first frame update
        new void Start()
        {
            base.Start();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        #endregion

        #region SkillTreeManager Implementation
        protected override void LoadConfigFromVals()
        {
            skillTreeColor = vals.skillTree3Color;
            skillTreeDesc = vals.SkillTree3Description;
            skillTreeName = vals.skillTree3Name;
        }

        protected override void LoadConfigFromChar()
        {
            this.skillPointsSpend = co.powerSkill;
        }
        #endregion
    }
}
