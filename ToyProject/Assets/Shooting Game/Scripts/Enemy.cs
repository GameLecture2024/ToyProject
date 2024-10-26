using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Enemy : MonoBehaviour
    {
        [Header("속성")]
        public float speed = 5;
        private Vector3 dir;    // 멤버 변수여서 함수에서 같이 사용할 수 있다.

        public GameObject[] explosionFactory; // 1. Smoke, 2. fire 외부에서 만들어진 프리팹을 연결해준다.

        private void Start()
        {
            int randValue = UnityEngine.Random.Range(0, 10); //  

            if(randValue < 3) // 30%
            {
                GameObject player = GameObject.Find("Player");

                dir = player.transform.position - transform.position;
                dir.Normalize();
            }
            else
            {
                dir = Vector3.down;
            }

        }

        // Update is called once per frame
        void Update()
        {
            transform.position += dir * speed * Time.deltaTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("DeadZone")) return;

            if (other.CompareTag("Bullet"))
            {
                GameObject fire = Instantiate(explosionFactory[1]);
                fire.transform.position = transform.position;
            }

            if (other.CompareTag("Player"))
            {
                GameObject smoke = Instantiate(explosionFactory[0]);
                smoke.transform.position = transform.position;
            }


            Destroy(other.gameObject); // 충돌한 대상 없애버린다.
            Destroy(gameObject);       // 나도 없애버린다.
        }
    }
}
