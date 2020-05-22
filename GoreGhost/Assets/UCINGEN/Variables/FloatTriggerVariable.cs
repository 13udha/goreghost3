using System;
using UnityEngine;

namespace Com.UCI307.UCINGEN
{
    [CreateAssetMenu(fileName = "New Float Trigger Variable", menuName = "UCINGEN/Variables/Float Trigger")]
    public class FloatTriggerVariable : FloatVariable, ISerializationCallbackReceiver
    {
        #region Public Fields
        public GameEvent onSet;
        public GameEvent onChange;
        #endregion

        #region Public Methods
        public override void SetValue(float value)
        {
            base.SetValue(value);
            if(onSet != null)
            {
                onSet.Raise();
            }
        }

        public override void SetValue(FloatVariable value)
        {
            base.SetValue(value);
            if(onSet != null)
            {
                onSet.Raise();
            }
        }

        public override void ApplyChange(float amount)
        {
            base.ApplyChange(amount);
            if(onChange != null)
            {
                onChange.Raise();
            }
        }

        public override void ApplyChange(FloatVariable amount)
        {
            base.ApplyChange(amount);
            if(onChange != null)
            {
                onChange.Raise();
            }
        }
        #endregion

    }
}
