using System;
using System.Collections;
using System.Collections.Generic;
using pest;
using UnityEngine;

namespace team2
{
    public class DataManager : MonoBehaviour
    {
        public static DataManager Instance;

        public GameObject mainUI;
        public SceneManagement sceneManager;
        public UITransitions transitions;
        public SoundManager soundManager;
        public InformationManager info;
        public IslandManager island;
        
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
