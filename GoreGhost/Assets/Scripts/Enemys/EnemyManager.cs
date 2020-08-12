using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class EnemyManager : MonoBehaviour, IDamagable
    {
        #region Public Fields

        public enum AI_MODE { WALK, ATTACK, WAIT};

        [Header("Dependencies")]
        public EnemyValues values;
        public EnemyObject data;
        public Animator anim;
        public Rigidbody2D rb;
        public CharacterRuntimeSet players;
        public Transform attackPoint;
        public LayerMask attackLayers;

        #endregion

        #region Private Fields
        private AI_MODE mode;

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

        //Movement
        private Vector2 moveVelocity;
        
        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            mode = AI_MODE.WAIT;
            dead = false;
            retargetingTime = Time.time + values.startupDelay;
            ReadFromData();
        }

        // Update is called once per frame
        void Update()
        {
            Behaviour();
        }

        private void FixedUpdate()
        {
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
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
            mode = AI_MODE.WALK;
        }

        private void Die()
        {
            dead = true;
            anim.SetTrigger(ANIM_DEATH);
            corpseTimer = Time.time + values.corpseTimer;
        }
        #endregion

        #region Behaviour

        private void Behaviour()
        {
            //targeting
            if (Time.time >= retargetingTime)
            {
                GetTarget();
            }

            //corpseTime
            if (corpseTimer != 0 && Time.time >= corpseTimer)
            {
                GameObject.Destroy(this.gameObject);
            }

            switch (mode)
            {
                case AI_MODE.ATTACK:
                    break;
                case AI_MODE.WALK:
                        Movement();
                    break;
                case AI_MODE.WAIT:
                    break;
            }

                
        }


        private void Movement()
        {
            //Aiming
            Vector2 direction = targetCords.position - attackPoint.position;

            //Moving
            moveVelocity = direction.normalized * data.movementSpeed;
            if (moveVelocity != Vector2.zero)
            {
                if (moveVelocity.x < 0)
                {
                    transform.rotation = Quaternion.Euler(0, -180, 0);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                anim.SetBool(ANIM_WALKING, true);
            }
            else
            {
                anim.SetBool(ANIM_WALKING, false);
            }

            //Progressing
            if(targetCords.position == attackPoint.position)
            {
                mode = AI_MODE.ATTACK;
            }
        }

        #endregion
    }
}
