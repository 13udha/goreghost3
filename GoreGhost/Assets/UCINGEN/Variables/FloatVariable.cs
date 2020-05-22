using System;
using UnityEngine;

namespace Com.UCI307.UCINGEN
{
    [CreateAssetMenu(fileName = "New Float Variable", menuName = "UCINGEN/Variables/Float")]
    public class FloatVariable : ScriptableObject, ISerializationCallbackReceiver
    {
        public float InitalValue;

        [NonSerialized]
        public float Value;

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
        public virtual void SetValue(float value)
        {
            Value = value;
        }

        public virtual void SetValue(FloatVariable value)
        {
            Value = value.Value;
        }

        public virtual void ApplyChange(float amount)
        {
            Value += amount;
        }

        public virtual void ApplyChange(FloatVariable amount)
        {
            Value += amount.Value;
        }
        #endregion

    }
}
