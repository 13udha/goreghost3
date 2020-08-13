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
            Debug.Log("yeet");
        }

        #endregion
    }
}
