using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team2
{
    public class ClickAndDrag : MonoBehaviour
    {
        private LineRenderer line;
        private BoxCollider2D mouseCollider;
        private bool isDrawing = false;
        private Vector3 screenPos;
        public Vector3 worldPos;
        
        // Start is called before the first frame update
        void Start()
        {
            line = GetComponent<LineRenderer>();
            mouseCollider = GetComponent<BoxCollider2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                isDrawing = true;
                screenPos = Input.mousePosition;
                worldPos = Camera.main.ScreenToWorldPoint(screenPos);
                worldPos.z = 0;

                mouseCollider.offset = worldPos;
                
                if (isDrawing)
                {
                    line.SetPosition(line.positionCount++, worldPos);
                }
            }
            else if (Input.GetMouseButtonUp(0) && isDrawing)
            {
                isDrawing = false;
                line.positionCount = 0;
                mouseCollider.offset = new Vector2(0, 0);
            }
        }
    }
}
