using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class EnemyManager : MonoBehaviour
    {
        [Header("속성")]
        public GameObject EnemyFactory;   // 몬스터 생산하는 공장
        public float createTime = 1;        // 몬스터 생성 시간
        public float currentTime;         // 현재 시간

        [Header("랜덤")]
        public int minTime = 1;
        public int maxTime = 4;
        // Start is called before the first frame update
        void Start()
        {
            // 랜덤 표현하는 방법
            createTime = UnityEngine.Random.Range(minTime, maxTime);   // 1 ~ 3
        }

        // Update is called once per frame
        void Update()
        {
            // 시간을 측정
            currentTime += Time.deltaTime;

            if(createTime <= currentTime)
            {
                InstantEnemy(); // 몬스터를 생성해라.
                currentTime = 0;
                createTime = UnityEngine.Random.Range(minTime, maxTime);
            }
            // 생성
        }

        void InstantEnemy()
        {
            GameObject enemy = Instantiate(EnemyFactory);
            enemy.transform.position = transform.position;
        }
    }
}
