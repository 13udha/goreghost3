using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = ("New Enemy Values"), menuName = "GoreGhost3/Config/EnemyValues")]
    public class EnemyValues : ScriptableObject
    {
        [Header("Behaviour")]
        public float retargetingTime;
        public float chaseTime;
        public float startupDelay;
        public float corpseTimer;
        public float hitStunDuration;
    }
}
