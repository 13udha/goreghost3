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
        public Animator animator;

        [Header("Debug")]
        public PickUpObject debugData;

        #endregion

        #region Private Fields

        private PickUpObject data;

        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            if(debugData != null)
            {
                SetData(debugData);
            }
            
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
            animator.runtimeAnimatorController = data.animator;
        }

        public PickUpObject GetData()
        {
            return data;
        }

        #endregion
    }
}
