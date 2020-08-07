using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "New PickUpData", menuName = "GoreGhost3/GameContent/PickUpData")]
    public class PickUpObject : ScriptableObject
    {
        #region Public Fields

        public enum PickUpType { Health, Energy, Experience }
        public string pickUpName;
        public PickUpType pickUpType;
        public float pickUpValue;
        #endregion
    }
}
