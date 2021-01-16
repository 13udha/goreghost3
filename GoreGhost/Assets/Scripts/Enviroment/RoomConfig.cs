using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [System.Serializable]
    public class RoomConfig
    {
        #region Public Fields

        public enum RoomSize { Minimum, Small, Medium, Large, ExtraLarge };

        [Header("Room Config")]
        public RoomSize size;
        public bool emptyRoom;
        [Tooltip("List of Enemys to Spawn and how much of each. X is the ID of the Enemy. Y is the amount of the specific Enemy")]
        public List<Vector2> enemys;

        #endregion

        #region Public Methods

        public float GetTotalEnemys()
        {
            if (enemys == null || emptyRoom)
                return 0;


            float x = 0;

            foreach(Vector2 v in enemys)
            {
                x += v.y;
            }

            return x;
        }

        #endregion

    }
}
