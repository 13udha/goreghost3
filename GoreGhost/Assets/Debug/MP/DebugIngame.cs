using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Com.UCI307.GOREGHOST3
{
    public class DebugIngame : MonoBehaviour
    {
        public MultiplayerCollection players;
        public List<PlayerInput> inputs;

        //public 
        // Start is called before the first frame update
        void Start()
        {

            List<MultiPlayerConfiguration> mps = MultiplayerConfigurationManager.Instance.GetPlayerInputs();
            foreach (MultiPlayerConfiguration mpd in mps)
            {
                //Debug.ö
                if(mpd.PlayerInput == null)
                {
                    Debug.Log("PLayer " + mpd.PlayerIndex + " has no input controlr ");
                }
                else
                {
                    Debug.Log("Player " + mpd.PlayerIndex + " has the player input with index " + mpd.PlayerInput.playerIndex);

                }
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}