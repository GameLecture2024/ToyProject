using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Background : MonoBehaviour
    {
        [Header("속성")]
        public Material bgMat;
        public float scrollSpeed = 0.2f;
        public Vector2 dirVec = Vector2.zero;

        // Update is called once per frame
        void Update()
        {
            // 이동방향 * 속력 * 시간
            Vector2 direction = dirVec; //Vector2.up; // 좌,우(대각선 위)
            bgMat.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;  
        }
    }
}
