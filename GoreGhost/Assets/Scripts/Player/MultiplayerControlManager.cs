using Com.UCI307.UCINGEN;
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
        [Header("Config")]
        public PlayerInput playerInput;
        public CharacterManager characterManager;

        [Header("Events")]
        public GameEvent gamePaused;
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

        #region Button Events
        public void OnMove(CallbackContext cc)
        {
            if(characterManager != null)
                characterManager.OnMove(cc.ReadValue<Vector2>());
            
        }

        public void NorthAction()
        {
            if (characterManager != null)
                characterManager.NorthButtonAction();
        }

        public void EastAction()
        {
            if (characterManager != null)
                characterManager.EastButtonAction();
        }

        public void SouthAction()
        {
            if (characterManager != null)
                characterManager.SouthButtonAction();
        }

        public void WestAction()
        {
            if (characterManager != null)
                characterManager.WestButtonAction();
        }

        public void R1Action()
        {
            if (characterManager != null)
                characterManager.R1ButtonAction();
        }

        public void L1Action()
        {
            if (characterManager != null)
                characterManager.L1ButtonAction();
        }

        public void StartButtonAction(CallbackContext cc)
        {
            if (cc.performed)
            { 
                gamePaused.Raise();
            }
        }
        #endregion

    }
}