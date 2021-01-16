using System;
using UnityEngine;

namespace Com.UCI307.UCINGEN
{
    [CreateAssetMenu(fileName = "New Int Variable", menuName = "UCINGEN/Variables/Int")]
    public class IntVariable : ScriptableObject, ISerializationCallbackReceiver
    {
        public int InitalValue;

        [NonSerialized]
        public int Value;

        #region Serialitation Callbacks
        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            Value = InitalValue;
        }
        #endregion

        #region Public Methods
        public virtual void SetValue(int value)
        {
            Value = value;
        }

        public virtual void SetValue(IntVariable value)
        {
            Value = value.Value;
        }

        public virtual void ApplyChange(int amount)
        {
            Value += amount;
        }

        public virtual void ApplyChange(IntVariable amount)
        {
            Value += amount.Value;
        }
        #endregion

    }
}
