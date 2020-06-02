using Com.UCI307.UCINGEN;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    public class CharSelectionPanelManager : MonoBehaviour
    {
        #region Public Fields
        [Header("Dependencys")]
        public MultiplayerData player;
        public CharacterCollection chars;
        public Text playerNameDisplay;
        public Text characterNameDisplay;
        public Image characterIconDispay;
        public Image characterImageDisplay;
        public Image backgroundPanel;

        [Header("Config")]
        public Color readyColor;
        public int playerIndex;
        

        [Header("Events")]
        public GameEvent playerReady;
        public GameEvent playerNotReady;

        #endregion

        #region PrivateFields
        private int currentCharIndex = 0;
        private MultiplayerSetupMenuManager manager;

        private Color baseColor;
        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        public void Awake()
        {
            baseColor = backgroundPanel.color;
            manager = FindObjectOfType<MultiplayerSetupMenuManager>();
            manager.RegisterPanel(this);
            SetUpDisplay(currentCharIndex);
            var root = FindObjectOfType<MultiplayerSetupMenuManager>();
            this.transform.SetParent(root.transform);
        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region PublicMethods
        public int GetPlayerIndex()
        {
            return playerIndex;
        }

        public void SetPlayerIndex(int i)
        {
            this.playerIndex = i;
            
            PlayerInput pi =  MultiplayerConfigurationManager.Instance.GetPlayerInputs()[i].PlayerInput;
            pi.uiInputModule = GetComponent<InputSystemUIInputModule>();
            //pass through type?
        }

        

        public void SetPlayerReady()
        {
            player.playingCharacter = chars.chars[currentCharIndex];
            player.isReady = true;
            backgroundPanel.color = readyColor;
            playerReady.Raise();
        }

        public void SetUpDisplay(int charIndex)
        {
            CharacterObject co = chars.chars[charIndex];
            characterNameDisplay.text = co.characterName;
            characterImageDisplay.sprite = co.prefab.GetComponentInChildren<SpriteRenderer>().sprite;
            Sprite tmpImage = co.profileImage;
            characterIconDispay.sprite = tmpImage;
            playerNameDisplay.color = player.playerColo;
            playerNameDisplay.text = "Player " + (player.PlayerIndex + 1);
        }

        public void NextCharacter()
        {
            if(currentCharIndex+1 >= chars.chars.Count)
            {
                currentCharIndex = 0;
                SetUpDisplay(currentCharIndex);
            }
            else
            {
                currentCharIndex += 1;
                SetUpDisplay(currentCharIndex);
            }
            SetPlayerNotReady();
        }

        public void PreviousCharacter()
        {
            if(currentCharIndex == 0)
            {
                currentCharIndex = chars.chars.Count - 1;
                SetUpDisplay(currentCharIndex);
            }
            else
            {
                currentCharIndex -= 1;
                SetUpDisplay(currentCharIndex);
            }
            SetPlayerNotReady();
        }
        #endregion

        #region Private Methods

        private void SetPlayerNotReady()
        {
            player.isReady = false;
            backgroundPanel.color = baseColor;
            playerNotReady.Raise();
        }

        #endregion
    }
}