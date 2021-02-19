using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public abstract class AEnemy : ABaseAI, IDamagable
    {
        #region Protected Fields

        protected float health;

        #endregion

        public abstract void TakeDamage(float damage);
    }
}