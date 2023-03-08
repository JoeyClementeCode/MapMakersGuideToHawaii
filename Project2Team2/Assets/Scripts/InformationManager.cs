using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace team2
{
    public class InformationManager : MonoBehaviour
    {
        public UIHolder currentRegion;
        public GameObject activeRegionUI;
        public GameObject tutorialPrefab;
        public GameObject clickAndDragPrefab;
        public GameObject explorationPrefab;
        [HideInInspector] public bool dropDownInUse = false;

        public void MakeDisplay()
        {
            InUse();
            GameObject newUI = Instantiate(currentRegion.region, transform, true);

            activeRegionUI = newUI;
            dropDownInUse = true;
        }
        
        public void MakeMicroDisplay()
        {
            InUse();
            GameObject newUI = Instantiate(currentRegion.micro, transform, true);
            
            activeRegionUI = newUI;
            dropDownInUse = true;
        }
        
        public void MakeResourceDisplay(GameObject prefab)
        {
            InUse();
            GameObject newUI = Instantiate(prefab, transform, true);
            
            
            activeRegionUI = newUI;
            dropDownInUse = true;
        }

        public void TutorialDisplay()
        {
            InUse();
            GameObject newUI = Instantiate(tutorialPrefab, transform, true);
            
            activeRegionUI = newUI;
            dropDownInUse = true;
        }
        
        public void ClickDisplay()
        {
            InUse();
            GameObject newUI = Instantiate(clickAndDragPrefab, transform, true);
            
            activeRegionUI = newUI;
            dropDownInUse = true;
        }
        
        public void ExplorationDisplay()
        {
            InUse();
            GameObject newUI = Instantiate(explorationPrefab, transform, true);
            
            activeRegionUI = newUI;
            dropDownInUse = true;
        }
        
        private void InUse()
        {
            if (activeRegionUI != null)
                Destroy(activeRegionUI);
            dropDownInUse = false;
        }

        private void Update()
        {
            if (dropDownInUse && Input.GetKeyDown(KeyCode.Escape))
            {
                InUse();
            }
        }
    }
}
