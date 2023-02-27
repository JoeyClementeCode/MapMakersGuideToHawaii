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
        
        public GameObject activeRegionUI;
        [HideInInspector] public bool dropDownInUse = false;
        public GameObject dropdownTemplate;
        

        public void CreateDisplay(int region)
        {
            switch (region)
            {
                case 0:
                    MakeDisplay(region1Info[0], region1Info[1]);
                    break;
                case 1:
                    MakeDisplay(region2Info[0], region2Info[1]);
                    break;
                case 2:
                    MakeDisplay(region3Info[0], region3Info[1]);
                    break;
                case 3:
                    MakeDisplay(region4Info[0], region4Info[1]);
                    break;
            }
        }

        private void MakeDisplay(string header, string text)
        {
            InUse();
            GameObject newUI = Instantiate(dropdownTemplate, GameObject.Find("MainCanvas").transform, true);
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
