using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class Enemy : MonoBehaviour
    {
        [Header("속성")]
        public float speed = 5;
        private Vector3 dir;   // 몬스터가 이동할 방향
        private void Start()
        {
            // 몬스터의 방향을 랜덤하게 정해주는 로직
            GetDirectionPattern();
        }

        private void GetDirectionPattern()
        {
            int randValue = UnityEngine.Random.Range(0, 10); // 0 ~ 9 사이의 값을 랜덤으로 가져온다.

            if (randValue < 3)
            {
                GameObject target = GameObject.Find("Player");
                dir = target.transform.position - transform.position;
                dir.Normalize();
            }
            else
            {
                dir = Vector3.down;
            }
        }

        private void Update()
        {
            transform.position += dir * speed * Time.deltaTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject); // 너 죽고
            Destroy(gameObject);       // 나 죽자
        }
    }
}
