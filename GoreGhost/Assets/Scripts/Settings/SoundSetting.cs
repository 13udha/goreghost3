using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "SoundSettings", menuName = "GoreGhost3/Settings/Sounds")]
    public class SoundSetting : ScriptableObject
    {
        #region Public Fields

        [Header("Volume")]
        public float AmbientSoundVolume = 30;
        public float EffektSoundVolume = 50;


        #endregion


    }
}