﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

namespace Com.UCI307.GOREGHOST3
{
    public class MultiplayerControlManager : MonoBehaviour
    {
        #region Public Fields
        public PlayerInput playerInput;
        #endregion

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
           
        }

        public void OnMove(CallbackContext cc)
        {
            Debug.Log(cc.ToString());
        }

    }
}