using System;
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
            
            if (transform.CompareTag("Region"))
            {
                button.onClick.AddListener(RegionButton);
            }
            else if (transform.CompareTag("Micro"))
            {
                button.onClick.AddListener(MicroButton);
            }
            else if (transform.CompareTag("Tutorial"))
            {
                button.onClick.AddListener(TutorialButton);
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
            DataManager.Instance.sceneManager.Load(1);

            switch (transform.parent.name)
            {
                case "Region 1 Micro(Clone)":
                    DataManager.Instance.island.region1Explored = true;
                    break;
                case "Region 2 Micro(Clone)":
                    DataManager.Instance.island.region2Explored = true;
                    break;
                case "Region 3 Micro(Clone)":
                    DataManager.Instance.island.region3Explored = true;
                    break;
                case "Region 4 Micro(Clone)":
                    DataManager.Instance.island.region4Explored = true;
                    break;
            }
            DataManager.Instance.island.inExplorationMode = DataManager.Instance.island.Explore();
            Destroy(transform.parent.gameObject);
        }

        private void TutorialButton()
        {
            DataManager.Instance.soundManager.SetAudio("PutDownPiece2");
            DataManager.Instance.info.InUse();
        }
    }
}
