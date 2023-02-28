using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace team2
{
    public class ClickAndDragObjectives : MonoBehaviour
    {
        private ClickAndDrag mouse;

        private void Start()
        {
            mouse = GameObject.Find("ClickAndDrag").GetComponent<ClickAndDrag>();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Line") && transform.tag == "End" && mouse.isDrawing)
            {
                switch (gameObject.transform.name)
                {
                    case "EndPoint1":
                        DataManager.Instance.info.MicroDisplay(0);
                        break;
                    case "EndPoint2":
                        DataManager.Instance.info.MicroDisplay(1);
                        break;
                    case "EndPoint3":
                        DataManager.Instance.info.MicroDisplay(2);
                        break;
                    case "EndPoint4":
                        DataManager.Instance.info.MicroDisplay(3);
                        break;
                }
            }

            if (col.gameObject.CompareTag("Line") && transform.tag == "Start")
            {
                mouse.canDraw = true;
            }

            if (col.gameObject.CompareTag("Line") && transform.tag == "Obstacle")
            {
                mouse.ResetLine();
            }
        }
    }
}
