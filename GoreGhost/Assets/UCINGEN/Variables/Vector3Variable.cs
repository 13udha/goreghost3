using System;
using UnityEngine;

namespace Com.UCI307.UCINGEN
{
    [CreateAssetMenu(fileName = "New Vector3 Variable", menuName = "UCINGEN/Variables/Vector3")]
    public class Vector3Variable : ScriptableObject, ISerializationCallbackReceiver
    {
        public Vector3 InitalValue;

        [NonSerialized]
        public Vector3 Value;

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
        public void SetValue(Vector3 value)
        {
            Value = value;
        }

        public void SetValue(Vector3Variable value)
        {
            Value = value.Value;
        }
        #endregion

    }
}
