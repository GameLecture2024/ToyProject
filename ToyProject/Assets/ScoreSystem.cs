using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace ClassStudy
{
    public class ScoreSystem : MonoBehaviour
    {
        [Header("속성")]
        public TextMeshProUGUI currentScore;
        public TextMeshProUGUI bestScore;

        public int score;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            currentScore.text = $"현재 점수 : {score}";
        }
    }
}
