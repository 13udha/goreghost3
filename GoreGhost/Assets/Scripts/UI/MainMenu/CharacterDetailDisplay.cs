using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    public class CharacterDetailDisplay : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencies")]
        public Text nameDisplay;
        public Image charImageDisplay;
        public StatBlockManager statBlock;
        public GameObject skillTree;
        public Text description;

        #endregion

        #region PrivateFields

        CharacterObject co; 

        #endregion

        #region MonoB Callbacks
        // Start is called before the first frame update
        void Start()
        {
            foreach (Transform child in transform)
                child.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        #endregion

        #region Public Methods

        public void SetUpCharacter(CharacterObject co)
        {
            foreach (Transform child in transform)
                child.gameObject.SetActive(true);

            this.co = co;
            nameDisplay.text = co.characterName;
            description.text = co.description;
            charImageDisplay.sprite = co.prefab.GetComponentInChildren<SpriteRenderer>().sprite;
            statBlock.SetUpDisplay(co);

        }

        #endregion
    }
}
