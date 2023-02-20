using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team2
{
    public class UITransitions : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Action(true);
        }

        public void Action(bool fade)
        {
            switch (gameObject.tag)
            {
                case "Region":
                    RegionTransition();
                    break;
                case "SceneTransition":
                    SceneTransition(fade);
                    break;
            }
        }
        
        private void SceneTransition(bool fade)
        {
            if (fade)
                LeanTween.alphaCanvas(this.gameObject.GetComponent<CanvasGroup>(), 0.0f, 1.0f);
            else
                LeanTween.alphaCanvas(this.gameObject.GetComponent<CanvasGroup>(), 1.0f, 1.0f);
        }
        
        private void RegionTransition()
        {
            Vector3 initialPosition = transform.position;
            transform.position = new Vector3(2500, initialPosition.y, 0);
            LeanTween.moveX(this.gameObject, initialPosition.x, 0.5f);
        }
    }
}
