using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class CharacterManager : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencies")]
        public CharacterObject character;
        public Rigidbody2D rb;
        public PlayerCharacterStatus status;
        public Transform attackPoint;
        public LayerMask enemyLayers;

        #endregion

        #region Private Fields
        private Vector2 moveVector;
        private Vector2 moveVelocity;

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
            moveVelocity = moveVector.normalized * character.movementSpeed;
            if (moveVelocity != Vector2.zero)
            {
                animator.SetBool(animWalking, true);
            }
            else
            {
                animator.SetBool(animWalking, false);
            }
        }

        private void FastAttack()
        {
            animator.SetTrigger(animFastAttack);
            Collider2D[] hitEnemys = Physics2D.OverlapCircleAll(attackPoint.position, character.fastAttackRange, enemyLayers);
            foreach(Collider2D enemy in hitEnemys)
            {
                Debug.Log("We hit " + enemy.name);
            }
        }

        private void StrongAttack()
        {
            animator.SetTrigger(animStrongAttack);
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
            Gizmos.DrawWireSphere(attackPoint.position, character.fastAttackRange);
        }

        #endregion
    }
}