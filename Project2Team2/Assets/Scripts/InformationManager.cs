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
        public List<string> region1Info;
        public List<string> region2Info;
        public List<string> region3Info;
        public List<string> region4Info;

        public List<string> region1Micro;
        public List<string> region2Micro;
        public List<string> region3Micro;
        public List<string> region4Micro;
        
        public GameObject activeRegionUI;
        [HideInInspector] public bool dropDownInUse = false;
        
        [Header("Templates")]
        public GameObject regionTemplate;
        public GameObject microTemplate;
        
        
        public void CreateDisplay(int region)
        {
            switch (region)
            {
                case 0:
                    MakeDisplay(region1Info[0], region1Info[1], "Region 1");
                    break;
                case 1:
                    MakeDisplay(region2Info[0], region2Info[1], "Region 2");
                    break;
                case 2:
                    MakeDisplay(region3Info[0], region3Info[1], "Region 3");
                    break;
                case 3:
                    MakeDisplay(region4Info[0], region4Info[1], "Region 4");
                    break;
            }
        }
        
        public void MicroDisplay(int region)
        {
            switch (region)
            {
                case 0:
                    MakeMicroDisplay(region1Micro[0], region1Micro[1]);
                    break;
                case 1:
                    MakeMicroDisplay(region2Micro[0], region2Micro[1]);
                    break;
                case 2:
                    MakeMicroDisplay(region3Micro[0], region3Micro[1]);
                    break;
                case 3:
                    MakeMicroDisplay(region4Micro[0], region4Micro[1]);
                    break;
            }
        }
        
        private void MakeDisplay(string header, string text, string regionName)
        {
            InUse();
            GameObject newUI = Instantiate(regionTemplate, transform, true);
            newUI.name = regionName;
            DropdownHolder textBoxes = newUI.GetComponent<DropdownHolder>();
            textBoxes.SetText(header, text);
            
            activeRegionUI = newUI;
            dropDownInUse = true;
        }
        
        private void MakeMicroDisplay(string header, string text)
        {
            InUse();
            GameObject newUI = Instantiate(microTemplate, transform, true);
            DropdownHolder textBoxes = newUI.GetComponent<DropdownHolder>();
            textBoxes.SetText(header, text);
            
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
