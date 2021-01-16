using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class Crate : ARoomboundObject, IDamagable
    {

        #region Public Fields 

        public int hp;

        #endregion
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }


        #region RoomboundObject Implementation

        public override void OnLevelInitialization()
        {
            throw new System.NotImplementedException();
        }

        public override void OnRoomActivation()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Damagable Implementation
        
        public void TakeDamage(float damage)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
