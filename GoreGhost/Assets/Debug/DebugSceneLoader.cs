using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.UCI307.GOREGHOST3.YouShouldDeleteThis
{
    public class DebugSceneLoader : MonoBehaviour
    {
        public string SceneName;

        private void Awake()
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}