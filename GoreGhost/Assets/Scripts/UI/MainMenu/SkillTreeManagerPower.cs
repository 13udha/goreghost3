using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class SkillTreeManagerPower : ASkillTreeManager
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

        #region ASkillTreeImplementation

        protected override void LoadConfigFromVals()
        {
            skillTreeColor = vals.skillTree1Color;
            skillTreeDesc = vals.SkillTree1Description;
            skillTreeName = vals.skillTree1Name;
        }

        protected override void LoadConfigFromChar()
        {
            this.skillPointsSpend = co.skillTree1;
        }

        #endregion

    }
}
