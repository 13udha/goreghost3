using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.GOREGHOST3
{
    public class CharacterRosterDisplayManager : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencies")]
        public GameObject rosterButtonPrefab;
        public GameObject detailDisplay;
        public CharacterCollection chars;

        #endregion

        #region Private Fields
        
        private CharacterDetailDisplay details;

        #endregion

        #region MonoBe Callbacks
        // Start is called before the first frame update
        void Start()
        {
            details = detailDisplay.GetComponent<CharacterDetailDisplay>();
            SetUpButtons();
        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Private Methods
        
        private void SetUpButtons()
        {
            foreach (CharacterObject co in chars.chars)
            {
                GameObject go = Instantiate<GameObject>(rosterButtonPrefab);
                go.transform.SetParent(this.transform);
                CharacterRosterButton crb = go.GetComponent<CharacterRosterButton>();
                crb.SetUpButton(co, details);
                
            }
        }

        #endregion
    }
}
