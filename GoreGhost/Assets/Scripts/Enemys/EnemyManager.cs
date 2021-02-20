using Com.UCI307.UCINGEN;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class EnemyManager : AEnemy, IDamagable
    {
        #region Public Fields

        [Header("Dependencies")]
        public EnemyValues values;
        public MinionObject data;
        public Animator anim;
        public Rigidbody2D rb;
        public CharacterRuntimeSet players;
        public Transform attackPoint;
        public Transform attackPosition;
        public LayerMask attackLayers;
        public GameobjectTriggerSet activeEnemys;

        #endregion

        #region Private Fields

        //Target
        private CharacterManager target;
        private Transform targetCords;
        
        //Local Vars
        private string enemyName;

        private bool stunned;

        //ANIM
        private static string ANIM_WALKING = "walking";
        private static string ANIM_ATTACK = "attack";
        private static string ANIM_HITSTUN = "hitStun";
        private static string ANIM_DEATH = "death";

        //Movement
        private Vector2 moveVelocity;

        //Attacking
        private float nextAttack;
        private int currentConsecAttacks;
        private int maxConsecAttacks;

        //Stunned
        private float stunnedTimer;

        protected string EnemyName { get => enemyName; set => enemyName = value; }
        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            mode = AI_MODE.SETUP;
            resetTime = Time.time + values.startupDelay;
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

        private void OnEnable()
        {
            activeEnemys.Add(this.gameObject);
        }

        private void OnDisable()
        {
            activeEnemys.Remove(this.gameObject);
        }
        #endregion

        #region Damagable Implementation
        public override void TakeDamage(float damage)
        {
            if (mode == AI_MODE.DEAD)
                return;

            anim.SetTrigger(ANIM_HITSTUN);
            health -= damage;
            mode = AI_MODE.REACT;
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
            EnemyName = data.enemyName;
            health = data.health;
        }



        private void Die()
        {
            mode = AI_MODE.DEAD;
            anim.SetTrigger(ANIM_DEATH);
            despawnTimer = Time.time + values.corpseTimer;
        }
        #endregion

        #region Behaviour



        protected override void SetUp()
        {
            int x = Random.Range(0, (players.Get().Count));
            target = players.Get()[x];
            targetCords = target.gameObject.transform;
            mode = AI_MODE.WALK;
        }

        protected override void Movement()
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
                mode = AI_MODE.ACT;
                nextAttack = Time.time + (Random.Range(data.minAttackTime, data.maxAttackTime));
            }
        }

        protected override void Acting()
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
                    mode = AI_MODE.SETUP;
                }

                //set new timer
                nextAttack = Time.time + (Random.Range(data.minAttackTime, data.maxAttackTime));
                currentConsecAttacks++;
            }

            //progression
            if (maxConsecAttacks == currentConsecAttacks)
            {
                maxConsecAttacks = 0;
                mode = AI_MODE.SETUP;
            }
        }

        protected override void Reacting()
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
                mode = AI_MODE.SETUP;
            }
        }

        protected override void Dead()
        {
            //TODO: implement
            //throw new System.NotImplementedException();
        }
        #endregion
    }
}
