using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "MultiplayerCollection", menuName = "GoreGhost3/Player/MultiplayerCollection")]
    public class MultiplayerCollection : ScriptableObject
    {
        #region Public Fields
        public List<MultiplayerData> players;
        #endregion

        #region Public Methods

        public void NoOneReady()
        {
            foreach (MultiplayerData m in players)
            {
                m.isReady = false;
            }
        }

        public bool EveryoneReady()
        {
            bool ready = true;
            foreach(MultiplayerData m in players)
            {
                if (!m.isReady)
                {
                    ready = m.isReady;
                }
            }
            return ready;
        }

        #endregion
    }
}