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

        #region Button Events
        public void OnMove(CallbackContext cc)
        {
            if(characterManager != null)
                characterManager.OnMove(cc.ReadValue<Vector2>());
            
        }

        public void NorthAction()
        {
            Debug.Log(this.ToString());
            if (characterManager != null)
                characterManager.NorthButtonAction();
        }

        public void EastAction()
        {
            Debug.Log(this.ToString());
            if (characterManager != null)
                characterManager.EastButtonAction();
        }

        public void SouthAction()
        {
            Debug.Log(this.ToString());
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
            Debug.Log(this.ToString());
            if (characterManager != null)
                characterManager.R1ButtonAction();
        }

        public void L1Action()
        {
            Debug.Log(this.ToString());
            if (characterManager != null)
                characterManager.L1ButtonAction();
        }

        public void StartButtonAction()
        {
            Debug.Log(this.ToString());
        }
        #endregion

    }
}