using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class EnemyManager : MonoBehaviour
    {
        [Header("속성")]
        public float createTime = 1;    // 특정 시간
        private float currentTime;      // 일정 시간
        public GameObject enemyFactory; // 적 공장

        [Header("랜덤")]
        float minTime = 1;
        float maxTime = 5;

        private void Start()
        {
            // 랜덤 생성 시간
            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime; // 시간이 흐르다가

            if (currentTime > createTime) // 현재 시간이 특정 시간이 되면
            {
                GameObject enemy = Instantiate(enemyFactory);  // 적 생성
                enemy.transform.position = transform.position; // 위치는 EnemyManager의 위치

                currentTime = 0; // 현재 시간 초기화
                createTime = UnityEngine.Random.Range(minTime, maxTime);
            }
        }
    }
}
