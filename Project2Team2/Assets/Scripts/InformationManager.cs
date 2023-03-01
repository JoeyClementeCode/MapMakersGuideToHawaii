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
        
        private void InUse()
        {
            if (activeRegionUI != null)
                Destroy(activeRegionUI);
            dropDownInUse = false;
        }
    }
}
