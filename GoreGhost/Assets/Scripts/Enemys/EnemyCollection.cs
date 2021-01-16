using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    [CreateAssetMenu(fileName = "new Enemy Collection", menuName = "GoreGhost3/Enemys/EnemyCollection")]
    public class EnemyCollection : ScriptableObject
    {
        [Header("Content")]
        public List<EnemyObject> enemys;
    }
}
