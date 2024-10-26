using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class AudioUtility : MonoBehaviour
    {
        public AudioSource audioSource;

        // Start is called before the first frame update
        void Start()
        {
            float randomPitch = Random.Range(0.5f, 1.0f);

            audioSource.pitch = randomPitch;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
