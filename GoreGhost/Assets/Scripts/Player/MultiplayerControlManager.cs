using System.Collections;
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
        public CharacterManager characterManager;
        #endregion

        // Start is called before the first frame update
        void Start()
        {
            FindObjectOfType<MultiplayerConfigurationManager>().playerControls.Add(this);
        }

        // Update is called once per frame
        void Update()
        {
           
        }

        public void OnMove(CallbackContext cc)
        {
            if(characterManager != null)
            {
                characterManager.OnMove(cc.ReadValue<Vector2>());
            }
        }

    }
}