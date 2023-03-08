using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace team2
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] private GameObject helpScreen;
        [SerializeField] private GameObject mainUI;
        private bool helpLoaded = false;

        public void loadMenu()
        {
            StartCoroutine(LoadMenu());
        }
        
        public void loadGameStart()
        {
            StartCoroutine(LoadGameStart());
        }

        public void loadCredits()
        {
            StartCoroutine(LoadCredits());
        }

        
        public IEnumerator LoadMenu()
        {
            DataManager.Instance.transitions.Action();
            Destroy(DataManager.Instance.info.activeRegionUI);
            yield return new WaitForSeconds(1);
            DataManager.Instance.mainUI.SetActive(false);
            DataManager.Instance.transitions.Action();
            SceneManager.LoadScene(0);
        }

        public IEnumerator LoadGameStart()
        {
            DataManager.Instance.transitions.Action();
            yield return new WaitForSeconds(1);
            DataManager.Instance.mainUI.SetActive(true);
            DataManager.Instance.transitions.Action();
            SceneManager.LoadScene(1);

            if (!DataManager.Instance.sceneManager.tutorialShown)
            {
                DataManager.Instance.info.TutorialDisplay();
                DataManager.Instance.sceneManager.tutorialShown = true;
            }
        }

        public IEnumerator LoadCredits()
        {
            DataManager.Instance.transitions.Action();
            yield return new WaitForSeconds(1);
            DataManager.Instance.transitions.Action();
            SceneManager.LoadScene(6);
        }

        public void LoadHelpScreen()
        {
            if (!helpLoaded)
            {
                helpScreen.SetActive(true);
                mainUI.SetActive(false);
                helpLoaded = true;
            }
            else if (helpLoaded)
            {
                helpScreen.SetActive(false);
                mainUI.SetActive(true);
                helpLoaded = false;
            }
        }
        
        public void Quit()
        {
            Application.Quit();
        }
    }
}
