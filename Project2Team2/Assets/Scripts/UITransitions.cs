using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team2
{
    public class UITransitions : MonoBehaviour
    {
        public int sceneTransitionState = 0;
        
        // Start is called before the first frame update
        void Start()
        {
            Action();
        }

        public void Action()
        {
            switch (gameObject.tag)
            {
                case "Region":
                    RegionTransition();
                    break;
                case "SceneTransition":
                    if (sceneTransitionState == 0)
                        SceneTransitionIn();
                    else if (sceneTransitionState == 1)
                        SceneTransitionOut();
                    break;
            }
        }
        
        private void SceneTransitionIn()
        {
            this.gameObject.GetComponent<CanvasGroup>().alpha = 1.0f;
            LeanTween.alphaCanvas(this.gameObject.GetComponent<CanvasGroup>(), 0.0f, 1.0f);
            sceneTransitionState = 1;
        }

        private void SceneTransitionOut()
        {
            this.gameObject.GetComponent<CanvasGroup>().alpha = 0.0f;
            LeanTween.alphaCanvas(this.gameObject.GetComponent<CanvasGroup>(), 1.0f, 1.0f);
            sceneTransitionState = 0;
        }
        
        private void RegionTransition()
        {
            Vector3 initialPosition = transform.position;
            transform.position = new Vector3(2500, initialPosition.y, 0);
            LeanTween.moveX(this.gameObject, initialPosition.x, 0.5f);
        }
    }
}
