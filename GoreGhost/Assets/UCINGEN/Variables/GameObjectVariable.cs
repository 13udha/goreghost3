using UnityEngine;

namespace Com.UCI307.UCINGEN
{
    [CreateAssetMenu(fileName = "New Game Object Variable", menuName = "UCINGEN/Variables/Game Object")]
    public class GameObjectVariable : ScriptableObject
    {
        public GameObject Object;

        public virtual void SetValue(GameObject obj)
        {
            Object = obj;
        }

        public virtual void SetValue(GameObjectVariable obj)
        {
            Object = obj.Object;
        }

        public virtual void ClearValue()
        {
            Object = null;
        }
    }
}
