using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class CharacterAnimatiorEvents : MonoBehaviour
    {
        #region Private Fields
        private CharacterManager man;
        #endregion

        #region MonoB Callbacks

        void Start()
        {
            man = GetComponentInParent<CharacterManager>();    
        }

        #endregion

        public void FMagicCall()
        {
            man.FastMagicCall();
        }
    }
}
