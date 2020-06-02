using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

namespace Com.UCI307.GOREGHOST3
{
    /// <summary>
    /// Monobehaviour für das Steuerobjekt eines Spieler. Übeträgt die Eingaben des InputManagers an die gewünschte Spielfigur.
    /// </summary>
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