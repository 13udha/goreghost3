using Com.UCI307.UCINGEN;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "New Level Collection", menuName = "GoreGhost3/GameContent/Level/Level Collection")]
    public class GameLevelCollection : ScriptableObject
    {
        #region Public Fields

        [Header("Dependencys")]
        public GameEvent levelStatesUpdated;
        public List<GameLevelData> levels;

        #endregion

        #region Public Methods

        internal void UpdateLevelStates()
        {
            //debug leichter
            if(levels[0].levelState == 0)
            {
                levels[0].levelState = 1;
            }

            //update states
            for(int i = 0; i < levels.Count; i++)
            {
                if(i == levels.Count - 1)
                {
                    return;
                }
                else
                {
                    switch (levels[i].levelState)
                    {
                        case 0:
                            break;
                        case 1:
                            break;
                        case 2:
                            if(levels[i + 1].levelState == 0)
                            {
                                levels[i + 1].levelState = 1; 
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            levelStatesUpdated.Raise();
        }

        public void ResetProgress()
        {
            foreach (GameLevelData d in levels)
            {
                if(d.levelID == 0)
                {
                    d.levelState = 1;
                }
                else
                {
                    d.levelState = 0;
                }
            }
        }
        #endregion
    }
}