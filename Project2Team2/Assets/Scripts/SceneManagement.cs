using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace team2
{
    public class SceneManagement : MonoBehaviour
    {
        private bool inMicro = false;
        public void Load(int select)
        {
            StartCoroutine(LoadMicro(select));
        }
        
        public IEnumerator LoadMicro(int select)
        {
            if (!inMicro)
            {
                DataManager.Instance.transitions.Action();
                yield return new WaitForSeconds(1);
                DataManager.Instance.transitions.Action();
                DataManager.Instance.mainUI.SetActive(false);
                SceneManager.LoadScene(select);
                inMicro = true;
            }
            else
            { 
                DataManager.Instance.transitions.Action();
                yield return new WaitForSeconds(1);
                DataManager.Instance.transitions.Action();
                DataManager.Instance.mainUI.SetActive(true);
                SceneManager.LoadScene(select);
                inMicro = false;
            }
        }

        public void SelectMicro(int select)
        {
            
        }
    }
}
