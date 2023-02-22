using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team2
{
    public class DataManager : MonoBehaviour
    {
        public static DataManager Instance;

        public GameObject mainUI;
        public SceneManagement sceneManager;
        public UITransitions transitions;
        
        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
