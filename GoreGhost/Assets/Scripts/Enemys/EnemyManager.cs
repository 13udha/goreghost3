using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class EnemyManager : MonoBehaviour, IDamagable
    {
        #region Public Fields

        [Header("Dependencies")]
        public EnemyValues values;
        public EnemyObject data;
        public Animator anim;
        public CharacterRuntimeSet players;
        public Transform attackPoint;

        #endregion

        #region Private Fields
        //Target
        private CharacterManager target;
        private Transform targetCords;
        private float retargetingTime;

        //Local Vars
        private string enemyName;
        private float health;
        private bool dead;

        //ANIM
        private static string ANIM_WALKING = "walking";
        private static string ANIM_ATTACK = "attack";
        private static string ANIM_HITSTUN = "hitStun";
        private static string ANIM_DEATH = "death";

        private float corpseTimer = 0;
        
        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            dead = false;
            retargetingTime = Time.time + values.startupDelay;
            ReadFromData();
        }

        // Update is called once per frame
        void Update()
        {
            Behaviour();
        }
        #endregion
        
        #region Damagable Implementation
        public void TakeDamage(float damage)
        {
            if (!dead)
            {
                anim.SetTrigger(ANIM_HITSTUN);
                health -= damage;
                if(0 >= health)
                {
                    Die();
                }
            }
        }
        #endregion

        #region Private Methods

        private void Behaviour()
        {
            //targeting
            if(Time.time  >= retargetingTime)
            {
                GetTarget();
            }

            //corpseTime
            if(corpseTimer != 0 && Time.time >= corpseTimer)
            {
                GameObject.Destroy(this.gameObject);
            }
        }

        private void ReadFromData()
        {
            enemyName = data.enemyName;
            health = data.health;
        }

        private void GetTarget()
        {
            int x = Random.Range(0, (players.Get().Count));
            target = players.Get()[x];
            targetCords = target.gameObject.transform;
        }

        private void Die()
        {
            dead = true;
            anim.SetTrigger(ANIM_DEATH);
            corpseTimer = Time.time + values.corpseTimer;
        }
        #endregion
    }
}
