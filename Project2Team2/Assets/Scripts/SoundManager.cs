using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pest
{
    public class SoundManager : MonoBehaviour
    {
        public List<AudioClip> clips;
        private AudioSource source;

        private void Start()
        {
            source = GetComponent<AudioSource>();
        }
        
        public void SetAudio(string clip)
        {
            AudioClip audioClip = null;
            for (int i = 0; i < clips.Count; i++)
            {
                if (clips[i].name == clip)
                {
                    audioClip = clips[i];
                    break;
                }
            }

            if (audioClip != null)
            {
                source.clip = audioClip;
                source.Play();
            }
        }
    }
}
