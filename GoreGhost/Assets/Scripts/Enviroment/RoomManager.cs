using Com.UCI307.UCINGEN;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class RoomManager : MonoBehaviour
    {
        #region Public Fields
        public enum RoomClearCondition { Enemys, Event};

        [Header("Configuration")]
        public int roomSeqNr;
        public RoomClearCondition clearOn;
        public GameEvent roomCleared;

        [Header("Enemy Configuration")]

        public float initialSpawn;
        public float respawnTimer;

        [Tooltip("Prefabs of the Enemys to be Spawned")]
        public EnemyCollection enemyCollection;
        [Tooltip("How many of which Enemy to spawn. X is the ID as per the enemys list and Y is the amount of enemys to spawn")]
        public List<Vector2> enemysToSpawn;

        [Header("Dependencies")]
        public GameobjectTriggerSet activeEnemys;
        public GameObject rightBorder;
        public GameObject preBarrier;
        public List<Transform> spawnPoints;

        #endregion

        #region Private Fields

        private bool isDormantRoom;
        private int currentSpawnPoint;
        private float respawnTimePoint;
        private float currentTime;

        #endregion

        #region MonoB Callbacks

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            if (!isDormantRoom && respawnTimePoint < Time.time)
            {
                SpawnEnemy();
                respawnTimePoint = Time.time + respawnTimer;
            }
        }

        #endregion

        #region Public Methods

        public void WakeUpRoom()
        {
            //Var initializiation
            isDormantRoom = false;
            preBarrier.SetActive(true);
            
            currentSpawnPoint = 0;
            
            for(int i = 0; i < initialSpawn; i++)
            {
                SpawnEnemy();
            }
            respawnTimePoint = Time.time+respawnTimer;
            Debug.Log("Room " + roomSeqNr + ": is awake");
        }

        public void LayRoomDormant()    
        {
            Debug.Log("Room "+ roomSeqNr + ": is dormant");
            isDormantRoom = true;
            preBarrier.SetActive(false);
        }

        #endregion

        #region Private Methods

        private void SpawnEnemy()
        {
            //check for spawnable enemys
            if (enemysToSpawn.Count == 0)
            {
                //no more enemys to spawn
                return;
            }

            foreach (Vector2 v in enemysToSpawn)
            {    
                if (v.y == 0)
                {
                    enemysToSpawn.Remove(v);
                }

                if (enemysToSpawn.Count == 0)
                {
                    //no more enemys to spawn
                    return;
                }
            }

            //Spawn random enemy
            int n = Random.Range(0, enemysToSpawn.Count - 1);
            GameObject go = GameObject.Instantiate<GameObject>((enemyCollection.enemys[(int)enemysToSpawn[n].x]).prefab);
            go.transform.SetPositionAndRotation(spawnPoints[currentSpawnPoint].position, Quaternion.Euler(new Vector3(0, 0, 0)));
            enemysToSpawn[n] = new Vector2(enemysToSpawn[n].x, enemysToSpawn[n].y-1);

            //switch spawn point
            if (currentSpawnPoint == spawnPoints.Count - 1)
            {
                currentSpawnPoint = 0;
            }
            else
            {
                currentSpawnPoint++;
            }
        }

        #endregion

        #region Event Responses

        public void OnLastEnemyKilled()
        {
           if(enemysToSpawn.Count==0 && clearOn == RoomClearCondition.Enemys)
            {
                Debug.Log("No ENemys anmyore!");
                roomCleared.Raise();
            }
        }

        #endregion
    }
}
