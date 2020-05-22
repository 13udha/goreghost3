using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.UCINGEN
{
    [CreateAssetMenu(fileName = "New Float Reference", menuName = "UCINGEN/Variables/Float Reference")]
    [Serializable]
    public class FloatReference : ScriptableObject
    {
        public bool UseConstant = true;
        public float ConstantValue;
        public FloatVariable Variable;

        public FloatReference()
        { }

        public FloatReference(float value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public float Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator float(FloatReference reference)
        {
            return reference.Value;
        }
    }
}
