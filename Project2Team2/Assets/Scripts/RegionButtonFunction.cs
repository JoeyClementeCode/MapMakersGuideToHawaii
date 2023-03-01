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

        // Start is called before the first frame update
        void Start()
        {
            button = GetComponent<Button>();
            
            if (transform.parent.CompareTag("Region"))
            {
                button.onClick.AddListener(RegionButton);
            }
            else if (transform.CompareTag("Micro"))
            {
                button.onClick.AddListener(MicroButton);
            }
        }

        private void RegionButton()
        {
            DataManager.Instance.soundManager.SetAudio("PutDownPiece2");
            DataManager.Instance.sceneManager.Load(DataManager.Instance.info.currentRegion.levelSelect);
            Destroy(transform.parent.gameObject);
        }

        private void MicroButton()
        {
            DataManager.Instance.soundManager.SetAudio("PutDownPiece2");
            DataManager.Instance.sceneManager.Load(0);
            Destroy(transform.parent.gameObject);
        }
    }
}
