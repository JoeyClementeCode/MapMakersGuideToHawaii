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
        public bool tutorialShown = false;
        public bool clickShown = false;
        public bool explorationShown = false;
        public bool exploration2Shown = false;
        
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

                if (!clickShown)
                {
                    DataManager.Instance.info.ClickDisplay();
                    clickShown = true;
                }

                if (clickShown && DataManager.Instance.island.inExplorationMode && !exploration2Shown)
                {
                    DataManager.Instance.info.Exploration2Display();
                    exploration2Shown = false;
                }
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
        
        public void Quit()
        {
            Application.Quit();
        }
    }
}
