using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    public class CharacterStatusDisplayManager : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencies")]
        public MultiplayerData player;
        public Image characterIcon;
        public Text nameDisplay;
        public Slider healthBar;
        public Slider energyBar;

        #endregion

        #region Private Fields
        private PlayerCharacterStatus status;
        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {
            if (!player.isPlaying && !player.isReady)
            {

                GameObject.Destroy(this.gameObject);
            }
            else
            {
                status = player.status;
                characterIcon.sprite = player.GetCharacter().profileImage;
                nameDisplay.text = player.GetCharacter().characterName;
                nameDisplay.color = player.playerColo;
                healthBar.value = status.GetHealthPerc();
                energyBar.value = status.GetEnergyPerc();
            }
            
        }

        // Update is called once per frame
        void Update()
        {
            healthBar.value = status.GetHealthPerc();
            energyBar.value = status.GetEnergyPerc();
        }
        #endregion
    }
}