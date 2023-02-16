using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace team2
{
    public class Snapping : MonoBehaviour, IDropHandler
    {
        private DropdownManager uiManager;
        public Vector3 uiPosition;

        private void Start()
        {
            uiManager = GameObject.Find("MainCanvas").GetComponent<DropdownManager>();
        }

        public void OnDrop(PointerEventData eventData)
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableObjects draggableObject = dropped.GetComponent<DraggableObjects>();

            if (transform.gameObject.CompareTag(draggableObject.gameObject.tag))
            {
                draggableObject.dragParent = transform;
                draggableObject.set = true;

                switch (draggableObject.gameObject.tag)
                {
                    case "Island 1":
                        Lock(0);
                        break;
                    case "Island 2":
                        Lock(1);
                        break;
                    case "Island 3":
                        Lock(2);
                        break;
                    case "Island 4":
                        Lock(3);
                        break;
                }
                

            }
        }

        private void Lock(int region)
        {
            GameObject newUIText = Instantiate(uiManager.regions[region], transform.root, true);
            newUIText.transform.position = uiPosition;
            
            if (uiManager.dropDownInUse)
            {
                uiManager.InUse();
            }
            
            uiManager.activeRegionUI.Add(newUIText);
            uiManager.dropDownInUse = true;
        }
    }
}
