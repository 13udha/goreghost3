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
        public Button readyButton;

        [Header("Config")]
        public Color readyColor;
        #endregion


        #region PrivateFields
        public int playerIndex;
        private int currentCharIndex = 0;
        private MultiplayerSetupMenuManager manager;
        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        public void Awake()
        {
            Debug.Log("AWAKE!!");
            manager = FindObjectOfType<MultiplayerSetupMenuManager>();
            manager.RegisterPanel(this);
            playerNameDisplay.text = "Player " + (player.PlayerIndex+1);
            playerNameDisplay.color = player.playerColo;
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
        }

        public void SetUpPanel(MultiplayerData mpd)
        {
            player = mpd;
        }

        public void SetPlayerReady()
        {
            player.playingCharacter = chars.chars[currentCharIndex];
            player.isReady = true;
        }

        public void SetUpDisplay(int charIndex)
        {
            CharacterObject co = chars.chars[charIndex];
            characterNameDisplay.text = co.characterName;
            characterImageDisplay.sprite = co.profileImage;
            Sprite tmpImage = co.profileImage;
            characterIconDispay.sprite = tmpImage;
            
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
            player.isReady = false;
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
            player.isReady = false;

        }
        #endregion
    }
}