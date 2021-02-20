using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public abstract class AEnemyObject : ABaseAIObject
    {
        #region Public Fields

        [Header("Enemy Config")]
        public float ExpValue;
        
        #endregion
    }
}
