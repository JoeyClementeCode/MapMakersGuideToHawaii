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
            switch (gameObject.tag)
            {
                case "Region":
                    RegionTransition();
                    break;
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void RegionTransition()
        {
            Vector3 initialPosition = transform.position;
            transform.position = new Vector3(2500, initialPosition.y, 0);
            LeanTween.moveX(this.gameObject, initialPosition.x, 0.5f);
        }
    }
}
