using System;
using UnityEngine;

namespace Com.UCI307.UCINGEN
{
    [CreateAssetMenu(fileName = "New Int Trigger Variable", menuName = "UCINGEN/Variables/Int Trigger")]
    public class IntTriggerVariable : IntVariable, ISerializationCallbackReceiver
    {
        #region Public Fields
        public GameEvent onSet;
        public GameEvent onChange;
        #endregion

        #region Public Methods
        public override void SetValue(int value)
        {
            base.SetValue(value);
            if (onSet != null)
            {
                onSet.Raise();
            }
        }

        public override void SetValue(IntVariable value)
        {
            base.SetValue(value);
            if (onSet != null)
            {
                onSet.Raise();
            }
        }

        public override void ApplyChange(int amount)
        {
            base.ApplyChange(amount);
            if (onChange != null)
            {
                onChange.Raise();
            }
        }

        public override void ApplyChange(IntVariable amount)
        {
            base.ApplyChange(amount);
            if (onChange != null)
            {
                onChange.Raise();
            }
        }
        #endregion

    }
}
