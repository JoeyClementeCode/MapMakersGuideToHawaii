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
        private DropdownManager uiManager;
        public Vector3 uiPosition;

        private void Start()
        {
            mouse = GameObject.Find("ClickAndDrag").GetComponent<ClickAndDrag>();
            uiManager = GameObject.Find("DropdownManager").GetComponent<DropdownManager>();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Line") && transform.tag == "End" && mouse.isDrawing)
            {
                DataManager.Instance.sceneManager.Load(0);
                //GameObject newUIText = Instantiate(uiManager.regions[4], GameObject.Find("ButtonCanvas").transform, true);
                //newUIText.transform.position = new Vector3(0,0,0);
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
