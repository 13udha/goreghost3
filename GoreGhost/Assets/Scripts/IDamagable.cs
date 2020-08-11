using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{

    /// <summary>
    /// Interface to be implemented by objetcs that are to be damagable
    /// </summary>
    public interface IDamagable
    {
        /// <summary>
        /// This Method will be called upon being attacked.
        /// </summary>
        /// <param name="damage"> The Damage this Object is supposed to take</param>
        void TakeDamage(float damage);
    }

}
