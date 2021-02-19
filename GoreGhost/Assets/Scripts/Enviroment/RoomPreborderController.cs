using Com.UCI307.UCINGEN;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class RoomPreborderController : MonoBehaviour
    {
        #region Public Fields

        [Header("Depenencys")]
        public RoomManager rm;
        public GameEvent roomCleared;

        #endregion

        #region Monoheaviour Callbacks

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer == 13)
            {
                Debug.Log("palyer colli");
                roomCleared.Raise();
            }
        }

        #endregion
    }
}