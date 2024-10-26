using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class Background : MonoBehaviour
    {
        public Material bg;

        public float scrollSpeed = 0.25f;


        // Update is called once per frame
        void Update()
        {
            Vector2 dir = Vector2.up;
            bg.mainTextureOffset += dir * scrollSpeed * Time.deltaTime;
        }
    }
}
