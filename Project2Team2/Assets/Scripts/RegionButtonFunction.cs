using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace team2
{
    public class RegionButtonFunction : MonoBehaviour
    {
        private Button button;
        private SceneManagement scene;
        
        // Start is called before the first frame update
        void Start()
        {
            scene = GameObject.Find("SceneManager").GetComponent<SceneManagement>();
            button = GetComponent<Button>();
            button.onClick.AddListener(RegionButton);
        }

        private void RegionButton()
        {
            scene.LoadMicro();
            Destroy(this.transform.parent.gameObject);
        }
    }
}
