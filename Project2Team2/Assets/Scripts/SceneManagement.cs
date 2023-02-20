using System;
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
        private UITransitions transition;

        public void Start()
        {
            transition = GameObject.Find("TransitionUI").GetComponent<UITransitions>();
        }

        public void Load()
        {
            StartCoroutine(LoadMicro());
        }
        
        public IEnumerator LoadMicro()
        {
            if (!inMicro)
            {
                transition.Action(false);
                yield return new WaitForSeconds(1);
                mainUI.SetActive(false);
                SceneManager.LoadScene(1);
                inMicro = true;
            }
            else
            { 
                transition.Action(false);
                yield return new WaitForSeconds(1);
                mainUI.SetActive(true);
                SceneManager.LoadScene(0);
                inMicro = false;
            }
        }
    }
}
