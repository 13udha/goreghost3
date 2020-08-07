using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    public class CharacterRosterButton : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencies")]
        public Image icon;

        #endregion

        #region Private Fields

        private CharacterDetailDisplay detailDisplay;
        private CharacterObject co;

        #endregion

        #region Public Methods

        public void SetUpButton(CharacterObject newCO, CharacterDetailDisplay display)
        {
            detailDisplay = display;
            co = newCO;
            icon.sprite = co.profileImage;
        }

        public void OnClick()
        {
            detailDisplay.SetUpCharacter(co);
        }
        #endregion
    }
}
