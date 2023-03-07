using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team2
{
    public class NewSnapping : MonoBehaviour
    {
        private bool collided = false;
        
        private void OnTriggerStay2D(Collider2D other)
        {

            if (transform.gameObject.CompareTag(other.gameObject.tag) && !DataManager.Instance.island.inExplorationMode && !DataManager.Instance.info.dropDownInUse)
            {
                if (!other.gameObject.GetComponent<DraggableObject2>().isDragging && !collided)
                {
                    collided = true;
                    other.gameObject.transform.position = transform.position;
                    other.gameObject.transform.localScale = Vector3.one;
                    other.gameObject.GetComponent<DraggableObject2>().set = true;
                    other.gameObject.transform.parent = transform;
                    other.gameObject.GetComponent<ParticleSystem>().Play();
                    
                    DataManager.Instance.info.currentRegion = gameObject.GetComponent<UIHolder>();
                    DataManager.Instance.info.MakeDisplay();
                }
            }
            else
            {
                Debug.Log("In Exploration Mode");
            }
        }
        
                

    }
}
