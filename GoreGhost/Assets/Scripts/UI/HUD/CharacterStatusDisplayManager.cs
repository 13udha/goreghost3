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
        public Text nameDisplay;
        public Slider healthBar;
        public Slider energyBar;

        #endregion

        #region Monobehaviour Callbacks
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion
    }
}