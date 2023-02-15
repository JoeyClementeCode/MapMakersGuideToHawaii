using System.Collections;
using System.Collections.Generic;
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

            if (transform.gameObject.CompareTag(draggableObject.gameObject.tag))
            {
                draggableObject.dragParent = transform;
                draggableObject.enabled = false;
            }
        }
    }
}
