using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class PickUpManager : MonoBehaviour
    {

        #region Public Fields
        [Header("Configuration")]
        public PickUpObject data;

        #endregion

        #region Private Fields

        private Animator anim;

        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponentInChildren<Animator>();
            SetData(data);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        #endregion

        #region Public Methods

        public void Consumed()
        {
            GameObject.Destroy(this.gameObject);
        }

        public void SetData(PickUpObject newData)
        {
            this.data = newData;
            anim.SetTrigger(data.pickUpType.ToString());
        }

        public PickUpObject GetData()
        {
            return data;
        }

        #endregion
    }
}
