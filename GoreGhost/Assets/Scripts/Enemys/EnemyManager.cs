using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class EnemyManager : MonoBehaviour, IDamagable
    {
        #region Public Fields

        public enum AI_MODE { WALK, ATTACK, WAIT, FIND, STUNNED, DEAD};

        [Header("Dependencies")]
        public EnemyValues values;
        public EnemyObject data;
        public Animator anim;
        public Rigidbody2D rb;
        public CharacterRuntimeSet players;
        public Transform attackPoint;
        public Transform attackPosition;
        public LayerMask attackLayers;

        [Header("Conifg")]
        public AI_MODE mode;
        #endregion

        #region Private Fields

        //Target
        private CharacterManager target;
        private Transform targetCords;
        private float retargetingTime;

        //Local Vars
        private string enemyName;
        private float health;
        private bool stunned;

        //ANIM
        private static string ANIM_WALKING = "walking";
        private static string ANIM_ATTACK = "attack";
        private static string ANIM_HITSTUN = "hitStun";
        private static string ANIM_DEATH = "death";

        private float corpseTimer = 0;

        //Movement
        private Vector2 moveVelocity;

        //Attacking
        private float nextAttack;
        private int currentConsecAttacks;
        private int maxConsecAttacks;

        //Stunned
        private float stunnedTimer;
        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            mode = AI_MODE.FIND;
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
            if(mode == AI_MODE.WALK)
                rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        }
        #endregion

        #region Damagable Implementation
        public void TakeDamage(float damage)
        {
            if (mode == AI_MODE.DEAD)
                return;

            anim.SetTrigger(ANIM_HITSTUN);
            health -= damage;
            mode = AI_MODE.STUNNED;
            if(0 >= health)
            {
                Die();
                return;
            }
            stunnedTimer = Time.time + values.hitStunDuration;
            
        }
        #endregion

        #region Private Methods

        


        private void ReadFromData()
        {
            enemyName = data.enemyName;
            health = data.health;
        }

        

        private void Die()
        {
            mode = AI_MODE.DEAD;
            anim.SetTrigger(ANIM_DEATH);
            corpseTimer = Time.time + values.corpseTimer;
        }
        #endregion

        #region Behaviour

        private void Behaviour()
        {


            //corpseTime
            if (corpseTimer != 0 && Time.time >= corpseTimer)
            {
                GameObject.Destroy(this.gameObject);
            }

            switch (mode)
            {
                case AI_MODE.ATTACK:
                    Attacking();
                    break;
                case AI_MODE.WALK:
                    //movement
                    Movement();
                    break;
                case AI_MODE.WAIT:
                    break;
                case AI_MODE.FIND:
                    if (Time.time >= retargetingTime)
                    {
                        GetTarget();
                    }
                    break;
                case AI_MODE.STUNNED:
                    Stunned();
                    break;
                case AI_MODE.DEAD:
                    break;
            }

                
        }

        private void GetTarget()
        {
            int x = Random.Range(0, (players.Get().Count));
            target = players.Get()[x];
            targetCords = target.gameObject.transform;
            mode = AI_MODE.WALK;
        }

        private void Movement()
        {
            //Aiming
            Vector2 direction = targetCords.position - attackPosition.position;

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

 

            if(Vector3.Distance(attackPoint.position, targetCords.position) < data.attackRange)
            {
                anim.SetBool(ANIM_WALKING, false);
                mode = AI_MODE.ATTACK;
                nextAttack = Time.time + (Random.Range(data.minAttackTime, data.maxAttackTime));
            }
        }

        private void Attacking()
        {
            //setup
            if(maxConsecAttacks == 0)
            {
                maxConsecAttacks = Random.Range(1, data.maxConsecutiveAttacks);
                currentConsecAttacks = 0;
            }
            //behaviour
            if(Time.time > nextAttack)
            {
                //attack
                anim.SetTrigger(ANIM_ATTACK);
                Collider2D[] hitEnemys = Physics2D.OverlapCircleAll(attackPoint.position, data.attackRange, attackLayers);
                foreach (Collider2D enemy in hitEnemys)
                {
                    enemy.GetComponent<IDamagable>().TakeDamage(data.attackDamage);
                }
                //retarget if miss
                if(hitEnemys.Length == 0)
                {
                    maxConsecAttacks = 0;
                    mode = AI_MODE.FIND;
                }

                //set new timer
                nextAttack = Time.time + (Random.Range(data.minAttackTime, data.maxAttackTime));
                currentConsecAttacks++;
            }

            //progression
            if (maxConsecAttacks == currentConsecAttacks)
            {
                maxConsecAttacks = 0;
                mode = AI_MODE.FIND;
            }
        }

        private void Stunned()
        {
            //setup
            if(stunnedTimer == 0)
            {
                stunnedTimer = Time.time + values.hitStunDuration;
            }
            
            //behaviour

            //progression
            if(Time.time > stunnedTimer)
            {
                stunnedTimer = 0;
                mode = AI_MODE.FIND;
            }
        }
        #endregion
    }
}
