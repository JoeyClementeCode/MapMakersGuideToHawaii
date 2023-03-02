using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace team2
{
    public class DraggableObjects : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        [HideInInspector] public Transform dragParent;
        public bool set = false;
        private bool notMoved = true;


        public void OnBeginDrag(PointerEventData eventData)
        {
            if (!DataManager.Instance.island.inExplorationMode)
            {
                notMoved = true;
                dragParent = transform.parent;
                transform.SetParent(transform.parent);
                transform.SetAsLastSibling();
                Debug.Log("Begin Drag");
                if (notMoved)
                {
                    LeanTween.scale(this.gameObject, new Vector3(1.5f, 1.5f, 1.5f), 0.1f);
                    DataManager.Instance.soundManager.SetAudio("PickUpPiece");
                }
            }
            else
            {
                Debug.Log("In Exploration Mode");
            }
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (!DataManager.Instance.island.inExplorationMode)
            {
                Vector2 currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                notMoved = false;
                if (set == false)
                {
                    transform.position = new Vector3(currentPos.x,
                        currentPos.y, 0);
                }

            }
            else
            {
                Debug.Log("In Exploration Mode");
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (!DataManager.Instance.island.inExplorationMode)
            {
                Debug.Log("End Drag");
                transform.SetParent(dragParent);
                if (!notMoved)
                {
                    LeanTween.scale(this.gameObject, new Vector3(1, 1, 1), 0.1f);
                    DataManager.Instance.soundManager.SetAudio("PutDownPiece1");
                }
            }
            else
            {
                Debug.Log("In Exploration Mode");
            }
        }
    }
}
