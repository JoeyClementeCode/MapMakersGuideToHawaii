using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team2
{
    public class DraggableObject2 : MonoBehaviour
    {
        public GameObject selectedObject;
        public bool isDragging = false;
        public bool set;
        Vector3 offset;
        void Update()
        {
            if (!DataManager.Instance.island.inExplorationMode)
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                if (Input.GetMouseButtonDown(0))
                {
                    Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
                    if (targetObject.gameObject.layer == 3  && targetObject != null) // Region Layer
                    {
                        isDragging = true;
                        selectedObject = targetObject.transform.gameObject;
                        offset = selectedObject.transform.position - mousePosition;
                        LeanTween.scale(selectedObject, new Vector3(1.0f, 1.0f, 1.5f), 0.1f);
                        DataManager.Instance.soundManager.SetAudio("PickUpPiece");
                    }
                }
                if (selectedObject)
                {
                    isDragging = true;
                    selectedObject.transform.position = mousePosition + offset;
                }
                if (Input.GetMouseButtonUp(0) && selectedObject)
                {
                    isDragging = false;
                    selectedObject = null;
                    DataManager.Instance.soundManager.SetAudio("PutDownPiece1");
                }
            }
        }
    }
}
