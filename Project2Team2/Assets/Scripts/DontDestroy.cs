using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team2
{
    public class DontDestroy : MonoBehaviour
    {
        // Start is called before the first frame update
        void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
