using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace team2
{
    public class SceneManagement : MonoBehaviour
    {
        public GameObject mainUI;
        public GameObject microUI;
        private bool inMicro = false;
        
        public void LoadMicro()
        {
            if (!inMicro)
            {
                mainUI.SetActive(false);
                microUI.SetActive(true);
                inMicro = true;
            }
            else
            {
                mainUI.SetActive(true);
                microUI.SetActive(false);
                inMicro = false;
            }
        }
    }
}
