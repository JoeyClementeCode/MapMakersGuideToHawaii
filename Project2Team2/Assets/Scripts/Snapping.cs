using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace team2
{
    public class Snapping : MonoBehaviour, IDropHandler
    {
        private InformationManager uiManager;
        public Vector3 uiPosition;

        private void Start()
        {
            uiManager = GameObject.Find("InformationManager").GetComponent<InformationManager>();
        }

        public void OnDrop(PointerEventData eventData)
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableObjects draggableObject = dropped.GetComponent<DraggableObjects>();
            
            if (transform.gameObject.CompareTag(draggableObject.gameObject.tag) && !IslandManager.inExplorationMode)
            {
                draggableObject.dragParent = transform;
                draggableObject.set = true;
                
                switch (draggableObject.gameObject.tag)
                {
                    case "Island 1":
                        uiManager.CreateDisplay(0);
                        break;
                    case "Island 2":
                        uiManager.CreateDisplay(1);
                        break;
                    case "Island 3":
                        uiManager.CreateDisplay(2);
                        break;
                    case "Island 4":
                        uiManager.CreateDisplay(3);
                        break;
                }
            }
        }
    }
}
