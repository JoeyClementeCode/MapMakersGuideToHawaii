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
            transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            LeanTween.scale(this.gameObject, new Vector3(1.75f, 1.75f, 1.75f), 0.5f);
        }
    }
}
