using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace team2
{
    public class SceneManagement : MonoBehaviour
    {
        public GameObject mainUI;
        private bool inMicro = false;
        
        public void LoadMicro()
        {
            if (!inMicro)
            {
                mainUI.SetActive(false);
                SceneManager.LoadScene(1);
                inMicro = true;
            }
            else
            { 
                mainUI.SetActive(true);
                SceneManager.LoadScene(0);
                inMicro = false;
            }
        }
    }
}
