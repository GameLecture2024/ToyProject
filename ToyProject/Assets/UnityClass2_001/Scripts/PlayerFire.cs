using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class PlayerFire : MonoBehaviour
    {

        [Header("속성")]
        public GameObject bulletFactory; // 총알이 생산하는 공장
        public Transform firePosition;   // 총알이 발사될 위치


        private void Update()
        {
            if(Input.GetButtonDown("Fire1"))
            {
                InstantBullet();
            }
        }

        void InstantBullet()
        {
            GameObject bullet = Instantiate(bulletFactory);

            bullet.transform.position = firePosition.transform.position;
        }
    }
}
