using Com.UCI307.UCINGEN;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class RoomManager : MonoBehaviour
    {
        #region Public Fields
        public enum RoomClearCondition { Enemys, External};

        [Header("Configuration")]
        public int roomSeqNr;
        public RoomClearCondition clearOn;

        [Header("Enemy Configuration")]

        public float initialSpawn;
        public float respawnTimer;

        [Tooltip("Prefabs of the Enemys to be Spawned")]
        public List<GameObject> enemys;
        [Tooltip("How many of which Enemy to spawn. X is the ID as per the enemys list and Y is the amount of enemys to spawn")]
        public List<Vector2> enemysToSpawn;

        [Header("Dependencies")]
        public GameobjectTriggerSet activeEnemys;
        public GameObject preBarrier;
        public List<Transform> spawnPoints;

        #endregion

        #region Private Fields

        private bool isDormantRoom;

        private int currentSpawnPoint;
        private float respawnTimePoint;
        private ARoomboundObject[] objs;

        #endregion

        #region MonoB Callbacks

        // Start is called before the first frame update
        void Start()
        {
            isDormantRoom = true;
            currentSpawnPoint = 0;
            respawnTimePoint = Time.time + respawnTimer;
        }

        // Update is called once per frame
        void Update()
        {
            //if()
        }

        #endregion

        #region Public Methods

        public void WakeUpRoom()
        {
            //Var initializiation
            isDormantRoom = false;
            
            currentSpawnPoint = 0;
            
            for(int i = 0; i < initialSpawn; i++)
            {
                SpawnEnemy();
            }
        }

        public void OnLevelInitialization()
        {
            objs = GetComponentsInChildren<ARoomboundObject>();

            foreach (ARoomboundObject a in objs)
            {
                a.OnLevelInitialization();
                a.gameObject.SetActive(false);
            }
        }

        public void OnRoomCleared()
        {

        }

        public void LayRoomDormant()
        {
            isDormantRoom = true;
        }

        #endregion

        #region Private Methods

        private void SpawnEnemy()
        {
            //check for spawnable enemys
            foreach (Vector2 v in enemysToSpawn)
            {
                if( v.y == 0)
                {
                    enemysToSpawn.Remove(v);
                }

                if (enemysToSpawn.Count == 0)
                {
                    //no more enemys to spawn
                    return;
                }

                int n = Random.Range(0, enemysToSpawn.Count-1);
                GameObject go = GameObject.Instantiate<GameObject>(enemys[(int) enemysToSpawn[n].x]);
                go.transform.SetPositionAndRotation(spawnPoints[currentSpawnPoint].position, Quaternion.Euler(new Vector3(0,0,0)));
                
                if(currentSpawnPoint == spawnPoints.Count - 1)
                {
                    currentSpawnPoint = 0;
                }
                else
                {
                    currentSpawnPoint++;
                }
            }
        }

        #endregion


    }
}
