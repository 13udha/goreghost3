using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    /// <summary>
    /// A Collective Event Responder for UI Signaling
    /// </summary>
    public class SignalManager : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencys")]
        public Image nextRoom;

        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            DeactivateAll();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        #endregion

        #region Private Methods
        
        private void DeactivateAll()
        {
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }
        }

        #endregion

        #region Event Responses
        
        public void OnLastEnemyKilled()
        {
            nextRoom.gameObject.SetActive(true);
        }

        public void OnRoomCleared()
        {
            nextRoom.gameObject.SetActive(false);
        }

        #endregion
    }
}