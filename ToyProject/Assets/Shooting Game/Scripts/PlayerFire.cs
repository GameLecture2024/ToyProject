using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class PlayerFire : MonoBehaviour
    {
        [Header("속성")]
        public GameObject bulletFactory; // 총알을 생산할 공장
        public Transform bulletPos;      // 총알이 생성될 위치

        // 플레이어의 입력 Input class
        // 공장 생성.      GameObject.Instatiate();

        // Update is called once per frame
        void Update()
        {
            // 플레이어의 마우스 왼쪽 클릭 입력
            if(Input.GetButtonDown("Fire1"))
            {
                InstantBullet();
            }

            // 플레이어의 스페이스 바
            if(Input.GetKeyDown(KeyCode.Space))
            {
                InstantBullet();
            }
        }

        void InstantBullet()
        {
            GameObject bullet = Instantiate(bulletFactory); // 총알을 생산한다.
            bullet.transform.position = bulletPos.position;
        }
    }
}
