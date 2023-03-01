using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace team2
{
    public class ClickAndDrag : MonoBehaviour
    {
        private LineRenderer line;
        public Slider slider;
        private BoxCollider2D mouseCollider;
        private Vector3 screenPos;
        public Vector3 worldPos;

        public bool isDrawing = false;
        public bool canDraw = false;
        
        public int maxDistanceCount = 60;
        int tempCount;

        public int extraObjectivesCount = 0;
        
        // Start is called before the first frame update
        void Start()
        {
            line = GetComponent<LineRenderer>();
            mouseCollider = GetComponent<BoxCollider2D>();
            slider.maxValue = maxDistanceCount;
            tempCount = maxDistanceCount;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(0) && line.positionCount < maxDistanceCount)
            {

                tempCount -= line.positionCount;
                slider.value = tempCount;
                screenPos = Input.mousePosition;
                worldPos = Camera.main.ScreenToWorldPoint(screenPos);
                worldPos.z = 0;

                mouseCollider.offset = worldPos;
                
                if (canDraw)
                {
                    isDrawing = true;
                    
                    if (isDrawing)
                    {
                        line.SetPosition(line.positionCount++, worldPos);
                    }
                }

            }
            else if (Input.GetMouseButtonUp(0) && isDrawing)
            {
                ResetLine();
            }
        }

        public void ResetLine()
        {
            tempCount = maxDistanceCount;
            canDraw = false;
            isDrawing = false;
            line.positionCount = 0;
            mouseCollider.offset = new Vector2(0, 0);
        }
    }
}
