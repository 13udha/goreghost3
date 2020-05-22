using UnityEngine;
using UnityEngine.Events;

namespace Com.UCI307.UCINGEN
{
    public class GameEventListener : MonoBehaviour
    {
        #region Public Fields
        [Tooltip("Event to listen to.")]
        public GameEvent Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent Response;
        #endregion

        #region Private Methods
        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }
        #endregion

        #region Public Methods
        public void OnEventRaised()
        {
            Response.Invoke();
        }
        #endregion
    }
}
