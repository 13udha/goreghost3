using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.UCINGEN
{
    public abstract class RuntimeSet<T> : ScriptableObject, ISerializationCallbackReceiver
    {
        #region Private Fields
        
        protected List<T> Items = new List<T>();

        #endregion

        #region Serialization Callbacks
        public void OnAfterDeserialize()
        {
            Items = new List<T>();
        }

        public void OnBeforeSerialize()
        {
        }
        #endregion

        #region Public Methods
        public virtual void Remove(T t)
        {
            if (this.Items.Contains(t))
            {
                Items.Remove(t);
            }
        }

        public virtual void Add(T t)
        {
            if (!this.Items.Contains(t))
            {
                Items.Add(t);
            }
           
        }

        public List<T> Get()
        {
            return Items;
        }
        #endregion

        #region Private Methods

        private void PurgeNulls()
        {
            for (var i = Items.Count - 1; i > -1; i--)
            {
                if (Items[i].GetType() == null)
                {
                    Items.RemoveAt(i);
                }
            }
        }

        #endregion
    }
}
