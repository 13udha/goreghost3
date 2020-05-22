using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.UCINGEN
{
    [CreateAssetMenu(fileName = "New GameObject Reference", menuName = "UCINGEN/Variables/GameObject Reference")]
    [Serializable]
    public class GameObjectReference : ScriptableObject
    {
        public bool UseConstant = true;
        public GameObject ConstantValue;
        public GameObjectVariable Variable;

        public GameObjectReference()
        { }

        public GameObjectReference(GameObject value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public GameObject Value
        {
            get { return UseConstant ? ConstantValue : Variable.Object; }
        }

        public static implicit operator GameObject(GameObjectReference reference)
        {
            return reference.Value;
        }
    }
}
