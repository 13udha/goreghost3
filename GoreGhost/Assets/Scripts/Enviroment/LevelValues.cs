using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Com.UCI307.GOREGHOST3.RoomConfig;

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

        public List<RoomConfig> listTest;

        #endregion

        #region Public Methods
        
        public float GetRoomSize(RoomSize s)
        {
            switch (s)
            {
                case RoomSize.Small:
                    return roomSmallSize * defaultRoomSize;
                case RoomSize.Medium:
                    return roomMediumSize * defaultRoomSize;
                case RoomSize.Large:
                    return roomLargeSize * defaultRoomSize;
                case RoomSize.ExtraLarge:
                    return roomExtraLargeSize * defaultRoomSize;
                default:
                    return roomMinSize * defaultRoomSize;
            }
        }
        
        #endregion
    }



}
