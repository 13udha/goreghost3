using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.UCINGEN
{
    [CreateAssetMenu(fileName = "New Game Object Trigger Variable", menuName = "UCINGEN/Variables/Game Object Trigger")]
    public class GameObjectTriggerVariable : GameObjectVariable
    {
        public GameEvent OnEnter;
        public GameEvent OnClear;

        public override void SetValue(GameObject obj)
        {
            base.SetValue(obj);
            OnEnter.Raise();
        }

        public override void SetValue(GameObjectVariable obj)
        {
            base.SetValue(obj);
            OnEnter.Raise();
        }

        public override void ClearValue()
        {
            base.ClearValue();
            OnClear.Raise();
        }
    }
}
