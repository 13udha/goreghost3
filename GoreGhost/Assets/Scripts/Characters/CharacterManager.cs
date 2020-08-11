using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class CharacterManager : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencies")]
        public CharacterObject data;
        public Rigidbody2D rb;
        public PlayerCharacterStatus status;
        public Transform attackPoint;
        public LayerMask enemyLayers;
        public SortingLayer pickUpLayer;
        public CharacterRuntimeSet activeCharacters;

        #endregion

        #region Private Fields
        private Vector2 moveVector;
        private Vector2 moveVelocity;
        private float attackCD = 0f;

        private Animator animator;
        private static string animWalking = "Walking";
        private static string animFastAttack  = "fast-attack";
        private static string animStrongAttack = "strong-attack";
        private static string animFastMagic = "fast-magic";
        private static string animStrongMagic = "strong-magic";
        private static string animJump = "jump";
        private static string animBlock = "block";
        private static string animHitStun = "hit-stun";
        private static string animDeath = "died";
        #endregion;


        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            this.animator = GetComponentInChildren<Animator>();
            moveVector = Vector2.zero;
        }

        // Update is called once per frame
        void Update()
        {
            Movement();
        }

        private void FixedUpdate()
        {
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            switch (collision.gameObject.layer)
            {
                case 15:
                    PickUpManager pum = collision.gameObject.GetComponent<PickUpManager>();
                    HandlePickUp(pum.GetData());
                    pum.Consumed();
                    break;
                default:
                    break;
            }
        }

        private void OnEnable()
        {
            activeCharacters.Add(this);
        }

        private void OnDisable()
        {
            activeCharacters.Remove(this);
        }
        #endregion

        #region Public Methods
        public void OnMove(Vector2 vec)
        {
            moveVector = vec;
            
        }
        #endregion

        #region Private Methods

        private void Movement()
        {
            moveVelocity = moveVector.normalized * data.movementSpeed;
            if (moveVelocity != Vector2.zero)
            {
                if(moveVelocity.x < 0)
                {
                    transform.rotation = Quaternion.Euler(0, -180, 0);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                animator.SetBool(animWalking, true);
            }
            else
            {
                animator.SetBool(animWalking, false);
            }
        }

        private void FastAttack()
        {
            if(Time.time >= attackCD)
            {
                animator.SetTrigger(animFastAttack);
                Collider2D[] hitEnemys = Physics2D.OverlapCircleAll(attackPoint.position, data.fastAttackRange, enemyLayers);
                foreach(Collider2D enemy in hitEnemys)
                {
                    Debug.Log("We hit " + enemy.name);
                    enemy.GetComponent<IDamagable>().TakeDamage(data.damage);
                }
                attackCD = Time.time + 1f / data.fastAttackRate;
            }
        }

        private void StrongAttack()
        {
            if(Time.time >= attackCD)
            {
                animator.SetTrigger(animStrongAttack);
                Collider2D[] hitEnemys = Physics2D.OverlapCircleAll(attackPoint.position, data.strongAttackRange, enemyLayers);
                foreach (Collider2D enemy in hitEnemys)
                {
                    Debug.Log("We hit " + enemy.name);
                    enemy.GetComponent<IDamagable>().TakeDamage(data.damage);
                }
                attackCD = Time.time + 1f / data.strongAttackRate;
            }
        }

        private void FastMagic()
        {
            animator.SetTrigger(animFastMagic);
        }

        private void StrongMagic()
        {
            animator.SetTrigger(animStrongMagic);
        }

        private void Jump()
        {
            animator.SetTrigger(animJump);
        }

        private void Block()
        {
            animator.SetTrigger(animBlock);
        }

        private void HandlePickUp(PickUpObject pu)
        {
            switch (pu.pickUpType)
            {
                case PickUpObject.PickUpType.Health:
                    status.RecoverHP(pu.pickUpValue);
                    break;
                case PickUpObject.PickUpType.Energy:
                    status.RecoverEnergy(pu.pickUpValue);
                    break;
                case PickUpObject.PickUpType.Experience:
                    if (data.ExperienceGain(pu.pickUpValue))
                    {
                        Debug.Log("Level Up!!");
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region ButtonPrompts

        public void NorthButtonAction()
        {
            StrongAttack();
        }

        public void EastButtonAction()
        {
            Block();
        }

        public void WestButtonAction()
        {
            FastAttack();
        }

        public void SouthButtonAction()
        {
            Jump();
        }

        public void L1ButtonAction()
        {
            StrongMagic();
        }

        public void R1ButtonAction()
        {
            FastMagic();
        }

        #endregion

        #region Debug

        private void OnDrawGizmosSelected()
        {
            Gizmos.DrawWireSphere(attackPoint.position, data.fastAttackRange);
        }

        #endregion
    }
}