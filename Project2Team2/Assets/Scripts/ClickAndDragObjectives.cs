using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            if (col.gameObject.CompareTag("Line") && transform.tag == "Finish")
            {
                Destroy(this.gameObject);
            }
        }
    }
}
