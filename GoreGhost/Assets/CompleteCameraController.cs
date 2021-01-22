using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Com.UCI307.GOREGHOST3 { 
    public class CompleteCameraController : MonoBehaviour
    {
        #region Public Fields
        [Header("Configuration")]
        public Vector2 minimumCameraPos;
        public Vector2 maximumCameraPos;

        [Header("Dependencies")]
        public CharacterRuntimeSet characters;
        #endregion

        #region Private Fields

        private bool setUp = false;
        private Transform player;        //Public variable to store a reference to the player game object
        private Vector3 offset;            //Private variable to store the offset distance between the player and camera
        
        #endregion

        #region MonoB Callbacks
        // Use this for initialization
        void Start()
        {
            
        }

        // LateUpdate is called after Update each frame
        void LateUpdate()
        {
            if (!setUp)
                return;

            // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
            //transform.position = player.transform.position + offset;
            Vector3 playerpos = player.position;
            playerpos.z = transform.position.z;
            //playerpos.y = transform.position.y;
            transform.position = new Vector3(Mathf.Clamp(playerpos.x, minimumCameraPos.x, maximumCameraPos.x), Mathf.Clamp(playerpos.y, minimumCameraPos.y, maximumCameraPos.y), transform.position.z);
        }
        #endregion

        #region Private Methods

        private void SetupCamera()
        {
            player = characters.Get()[0].gameObject.transform;
            //GameObject.Find("Player").transform;
            // TODO: find player

            //Calculate and store the offset value by getting the distance between the player's position and camera's position.
            offset = transform.position - player.transform.position;
            setUp = true;
        }

        #endregion

        #region Event Responses

        public void OnGameplayStarted()
        {
            SetupCamera();
        }

        #endregion
    }
}