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
            moveVelocity = moveVector.normalized * 10;
        }

        #endregion
    }
}