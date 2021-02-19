using Com.UCI307.UCINGEN;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "new Boss Status", menuName = "GoreGhost3/Enemys/Boss Status")]
    public class BossStatus : ScriptableObject
    {
        [Header("Status")]
        public float currentHealth;

        [Header("Events")]
        public GameEvent killed;
    }
}