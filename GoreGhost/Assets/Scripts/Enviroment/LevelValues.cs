using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "New Level Values", menuName = "GoreGhost3/Configuration/Level Values")]
    public class LevelValues : ScriptableObject
    {
        #region Public Fields

        [Header("Configurations")]
        public float minScreenX;
        public float minScreenY;
        public float maxScreenY;
        public Vector3 initialScreenPos;

        [Header("Room Configurations")]
        public float defaultRoomSize;
        public float roomMinSize;
        public float roomSmallSize;
        public float roomMediumSize;
        public float roomLargeSize;
        public float roomExtraLargeSize;
        

        #endregion

        #region Public Methods
        

        
        #endregion
    }



}
