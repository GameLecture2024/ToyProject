using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class PlayerMove : MonoBehaviour
    {
        // 목표
        // 플레이어를 움직인다.
        // 방향 : 위아래,왼쪽 오른쪽 
        // 속도 : 방향 x 속력

        [Header("속성")]
        public float speed=5; // 이동 속력

        // Update is called once per frame
        void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 dir = new Vector3(horizontal, vertical, 0);
            dir.Normalize();

            transform.position = transform.position + dir * speed * Time.deltaTime;
        }
    }
}
