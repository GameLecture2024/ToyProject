using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace ClassStudy
{
    public class boxmove : MonoBehaviour
    {
        public Transform endPoint;

        // Start is called before the first frame update
        void Start()
        {
            transform.DOMove(endPoint.position, 3).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        }

        // Update is called once per frame
        void Update()
        {
                
        }
    }
}
