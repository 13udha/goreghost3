using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "New PlayerData", menuName = "GoreGhost3/PlayerData")]
    public class PlayerData : ScriptableObject
    {
        #region Public Fields
        public string playerName;
        #endregion
    }
}
