using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public abstract class AProjectile : MonoBehaviour
    {
        #region Public Fields

        [Header("Configuration")]
        public int targetLayer;
        public float lifetime;
        public float speed;

        #endregion

        #region Protected Fields

        protected float timer;
        protected Vector2 dir;
        protected Rigidbody2D rb;
        private Vector2 velocity;
        
        #endregion

        #region MonoB Callbacks
        
        // Start is called before the first frame update
        void Start()
        {
            timer = Time.time + lifetime;
            rb = GetComponent<Rigidbody2D>();
            if (rb == null)
                Debug.Log("NO RB ON PROJECTILE!");
        }

        // Update is called once per frame
        void Update()
        {
            if (Time.time > timer)
                GameObject.Destroy(this.gameObject);

            Movement();
        }

        private void FixedUpdate()
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == targetLayer)
            {
                collision.gameObject.SendMessage("TakeDamage", 100);
                GameObject.Destroy(this.gameObject);
            }
        }
        #endregion

        #region Public Methods

        public void SetDirection(Vector2 v)
        {
            dir = v;
        }

        #endregion

        #region Protected Methods

        protected virtual void Movement()
        {
            velocity = dir.normalized * speed;
            if (velocity != Vector2.zero)
            {
                if (velocity.x < 0)
                {
                    transform.rotation = Quaternion.Euler(0, -180, 0);
                }
                else
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
        }

        #endregion
    }
}
