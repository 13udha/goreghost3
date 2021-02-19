using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "New Level Values", menuName = "GoreGhost3/GameContent/Level/Level Values")]
    public class LevelValues : ScriptableObject
    {
        #region Public Fields

        [Header("Configurations")]
        public float minScreenX;
        public float minScreenY;
        public float maxScreenY;
        public Vector3 initialScreenPos;

        #endregion

        #region Public Methods
        

        
        #endregion
    }



}
