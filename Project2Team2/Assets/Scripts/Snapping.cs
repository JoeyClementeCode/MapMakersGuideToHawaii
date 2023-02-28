using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

namespace team2
{
    public class Snapping : MonoBehaviour, IDropHandler
    {
        public void OnDrop(PointerEventData eventData)
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableObjects draggableObject = dropped.GetComponent<DraggableObjects>();
            
            if (transform.gameObject.CompareTag(draggableObject.gameObject.tag) && !DataManager.Instance.island.inExplorationMode)
            {
                draggableObject.dragParent = transform;
                draggableObject.set = true;
                
                switch (draggableObject.gameObject.tag)
                {
                    case "Island 1":
                        DataManager.Instance.info.CreateDisplay(0);
                        break;
                    case "Island 2":
                        DataManager.Instance.info.CreateDisplay(1);
                        break;
                    case "Island 3":
                        DataManager.Instance.info.CreateDisplay(2);
                        break;
                    case "Island 4":
                        DataManager.Instance.info.CreateDisplay(3);
                        break;
                }
            }
            else
            {
                Debug.Log("In Exploration Mode");
            }
        }
    }
}
