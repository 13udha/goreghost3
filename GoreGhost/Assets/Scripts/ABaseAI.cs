using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public abstract class ABaseAI : MonoBehaviour
    {
        /**
         * The Base States for this AI. Switch between States to influence behaviours
         */

        #region Public Fields

        public enum AI_MODE { WALK, ACT, WAIT, SETUP, REACT, DEAD };
        
        [Header("Base AI Conifg")]
        // State of this Instance of the AI
        public AI_MODE mode;

        //how long does the ai remain on field after being declared "Dead"
        protected float despawnTimer = 0;

        protected float resetTime;
        #endregion

        #region Behaviour

        protected void Behaviour()
        {
            //corpseTime
            if (despawnTimer != 0 && Time.time >= despawnTimer)
            {
                GameObject.Destroy(this.gameObject);
            }

            switch (mode)
            {
                case AI_MODE.ACT:
                    Acting();
                    break;
                case AI_MODE.WALK:
                    //movement
                    Movement();
                    break;
                case AI_MODE.WAIT:
                    break;
                case AI_MODE.SETUP:
                    if (Time.time >= resetTime)
                    {
                        SetUp();
                    }
                    break;
                case AI_MODE.REACT:
                    Reacting();
                    break;
                case AI_MODE.DEAD:
                    Dead();
                    break;
            }
        }

        protected abstract void Movement();

        protected abstract void SetUp();

        protected abstract void Acting();

        protected abstract void Reacting();

        protected abstract void Dead();
        #endregion

    }
}