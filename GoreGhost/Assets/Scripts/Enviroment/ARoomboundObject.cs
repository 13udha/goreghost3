using Com.UCI307.UCINGEN;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public abstract class ARoomboundObject : MonoBehaviour
    {

        #region Public Fields

        #endregion

        #region MonoB Callbacks

        void Start()
        {
        }

        void Update()
        {
        
        }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// called at the start of the level
        /// </summary>
        public abstract void OnLevelInitialization();

        /// <summary>
        /// called on activation of the room i.e. when the players reach the room
        /// </summary>
        public abstract void OnRoomActivation();

        #endregion
        
    }
}
