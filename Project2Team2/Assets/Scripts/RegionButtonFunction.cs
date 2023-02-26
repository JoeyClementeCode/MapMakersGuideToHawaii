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
        private int gameSelect = 0;

        // Start is called before the first frame update
        void Start()
        {
            button = GetComponent<Button>();
            
            if (transform.parent.CompareTag("Region"))
            {
                Selection();
                button.onClick.AddListener(RegionButton);
            }
            else if (transform.parent.CompareTag("Micro"))
            {
                button.onClick.AddListener(MicroButton);
            }
            

        }

        private void RegionButton()
        {
            DataManager.Instance.soundManager.SetAudio("PutDownPiece2");
            DataManager.Instance.sceneManager.Load(gameSelect);
            Destroy(transform.parent.gameObject);
        }

        private void MicroButton()
        {
            DataManager.Instance.soundManager.SetAudio("PutDownPiece2");
            DataManager.Instance.sceneManager.Load(0);
            Destroy(transform.parent.gameObject);
        }
        
        private void Selection()
        {
            switch (transform.tag)
            {
                case "Island 1":
                    gameSelect = 1;
                    break;
                case "Island 2":
                    gameSelect = 2;
                    break;
                case "Island 3":
                    gameSelect = 3;
                    break;
                case "Island 4":
                    gameSelect = 4;
                    break;
            }
        }
    }
}
