using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class CanonCarlManager : CharacterManager
    {
        #region Public Fields
        [Header("CharacterSpecifics")]
        public GameObject projectile;
        #endregion

        #region Character Manager Implementation

        protected override void FastMagicCS()
        {
            GameObject go = Instantiate(projectile);
            CanonCarl_Projectile ccp = go.GetComponent<CanonCarl_Projectile>();
            ccp.transform.position = new Vector2(attackPoint.position.x, attackPoint.position.y);
            if(this.transform.rotation.y == 0)
            {
                ccp.SetDirection(Vector2.right);
            }
            else
            {
                ccp.SetDirection(Vector2.left);
            }
            
        }

        #endregion
    }
}
