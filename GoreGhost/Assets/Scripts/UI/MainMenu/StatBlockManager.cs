using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.UCI307.GOREGHOST3
{
    public class StatBlockManager : MonoBehaviour
    {
        #region Public Fields

        [Header("Dependencies")]
        public Text display;

        #endregion

        #region MonoB Callbacks
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        #endregion

        #region Public Methods

        public void SetUpDisplay(CharacterObject co)
        {
            string s = "";

            s += "LEVEL: " + co.level + "\n";
            s += "EXPERIENCE POINTS: " + co.experience + "\n";
            s += "HEALTH: " + co.health + "\n";
            s += "ENERGY: " + co.energy + "\n";
            s += "MOVEMENT SPEED: " + co.movementSpeed + "\n";
            s += "DAMAGE: " + co.damage + "\n";
            s += "ARMOR: " + co.armor + "\n";
            s += "FAST ATTACK RANGE: " + co.fastAttackRange +"\n";
            s += "FAST ATTACK RATE: " + co.fastAttackRate +"\n";
            s += "STRONG ATTACK RANGE: " + co.strongAttackRange +"\n";
            s += "STRONG ATTACK RATE: " + co.strongAttackRate +"\n";


            display.text = s;
        }

        #endregion
    }
}
