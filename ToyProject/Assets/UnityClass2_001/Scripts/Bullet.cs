using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class Bullet : MonoBehaviour
    {
        // 필요 속성을 정의합니다.
        [Header("속성")]
        public float speed = 5;

        // 살아 있는 동안에는 계속
        private void Update()
        {
            // 속도 = 방향 x 속력
            // 방향 : 위로
            // 속력 : speed
            Vector3 dir = Vector3.up;

            transform.position += dir * speed * Time.deltaTime;
        }
    }
}
