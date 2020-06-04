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
        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
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
        }

        private void FastAttack()
        {
            Debug.Log("FAST ATTACK!!!");
            Collider2D[] hitEnemys = Physics2D.OverlapCircleAll(attackPoint.position, character.fastAttackRange, enemyLayers);
            foreach(Collider2D enemy in hitEnemys)
            {
                Debug.Log("We hit " + enemy.name);
            }
        }
        #endregion

        #region ButtonPrompts

        public void NorthButtonAction()
        {

        }

        public void EastButtonAction()
        {

        }

        public void WestButtonAction()
        {
            FastAttack();
        }

        public void SouthButtonAction()
        {

        }

        public void L1ButtonAction()
        {

        }

        public void R1ButtonAction()
        {

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