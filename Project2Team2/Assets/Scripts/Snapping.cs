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

                DataManager.Instance.info.currentRegion = gameObject.GetComponent<UIHolder>();
                DataManager.Instance.info.MakeDisplay();
            }
            else
            {
                Debug.Log("In Exploration Mode");
            }
        }
    }
}
