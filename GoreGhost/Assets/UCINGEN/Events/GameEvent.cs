using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.UCINGEN
{
    [CreateAssetMenu(fileName = "New Game Event", menuName = "UCINGEN/Events/Event")]
    public class GameEvent : ScriptableObject
    {
        #region Private Fields
        private List<GameEventListener> listeners = new List<GameEventListener>();
        #endregion

        #region Public Methods

        public void Raise()
        {
            Debug.Log(this.name + "Raised!!");
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised();
        }

        public void RegisterListener(GameEventListener listener)
        {
            if (!listeners.Contains(listener))
                listeners.Add(listener);
        }

        public void UnregisterListener(GameEventListener listener)
        {
            if (listeners.Contains(listener))
                listeners.Remove(listener);
        }

        #endregion
    }
}
