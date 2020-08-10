using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Com.UCI307.GOREGHOST3 { 
public class CompleteCameraController : MonoBehaviour
{

        private Transform player;        //Public variable to store a reference to the player game object
        public CharacterRuntimeSet characters;

        private Vector3 offset;            //Private variable to store the offset distance between the player and camera

        // Use this for initialization
        void Start()
        {

            player = characters.Get()[0].gameObject.transform;
                //GameObject.Find("Player").transform;
        
            //Calculate and store the offset value by getting the distance between the player's position and camera's position.
            offset = transform.position - player.transform.position;
        }

        // LateUpdate is called after Update each frame
        void LateUpdate()
        {
            // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
            //transform.position = player.transform.position + offset;
            Vector3 playerpos = player.position;
            playerpos.z = transform.position.z;
            transform.position = playerpos;
        }
    }
}