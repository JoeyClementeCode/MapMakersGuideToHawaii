using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team2
{
    public class DropdownManager : MonoBehaviour
    {
        public List<GameObject> regions;
        public List<GameObject> insights;
        public List<GameObject> activeRegionUI;
        [HideInInspector] public bool dropDownInUse = false;

        public void InUse()
        {
            for (int i = 0; i < activeRegionUI.Count; i++)
            {
                Destroy(activeRegionUI[i]);
            }
                
            activeRegionUI.Clear();
            dropDownInUse = false;
        }
    }
}
