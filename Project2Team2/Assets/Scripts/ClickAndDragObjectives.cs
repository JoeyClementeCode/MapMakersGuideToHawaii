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
        [SerializeField] private GameObject infoPopUp;

        private void Start()
        {
            mouse = GameObject.Find("ClickAndDrag").GetComponent<ClickAndDrag>();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Line") && transform.tag == "End" && mouse.isDrawing && mouse.extraObjectivesCount == 3)
            {
                DataManager.Instance.info.MakeMicroDisplay();
            }

            if (col.gameObject.CompareTag("Line") && transform.tag == "Start")
            {
                mouse.canDraw = true;
            }

            if (col.gameObject.CompareTag("Line") && transform.tag == "Obstacle")
            {
                mouse.ResetLine();
            }

            if (col.gameObject.CompareTag("Line") && transform.tag == "Extra")
            {
                mouse.extraObjectivesCount++;
            }
        }
        
        private void OnMouseDown()
        {
            if (DataManager.Instance.island.inExplorationMode)
            {
                DataManager.Instance.info.MakeResourceDisplay(infoPopUp);
            }
        }

        private void OnMouseEnter()
        {
            if (DataManager.Instance.island.inExplorationMode && (transform.tag != "Obstacle" || transform.tag != "Start"))
            {
                LeanTween.scale(gameObject, new Vector3(.55f, .55f, 1.5f), 0.05f);
            }
        }
        
        private void OnMouseExit()
        {
            if (DataManager.Instance.island.inExplorationMode && (transform.tag != "Obstacle" || transform.tag != "Start"))
            {
                LeanTween.scale(gameObject, new Vector3(.4f, .4f, 1.5f), 0.05f);
            }
        }
    }
}
