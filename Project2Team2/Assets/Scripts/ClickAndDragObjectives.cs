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
                DataManager.Instance.sceneManager.Load();
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
