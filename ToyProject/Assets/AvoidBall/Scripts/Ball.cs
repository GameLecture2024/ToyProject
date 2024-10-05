using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Ball : MonoBehaviour
    {
        // rigidbody
        // 색깔

        public float size;

        public enum Color { RED, Black, BLUE }
        public Color color;
        public float Speed = 5.0f;

        public void OnInitialize()
        {
            int RandomIndex = Random.Range(0, 3); // 0 , 1 , 2 

            color = (Color)RandomIndex;
            Speed = 5.0f;
            SetSpeedByColor();
        }

        public void SetSpeedByColor()
        {
            switch (color)
            {
                case Color.RED:
                    Speed = Speed * 2;
                    break;
                case Color.Black:
                    break;
                case Color.BLUE:
                    Speed = Speed * 1.2f;
                    break;
            }
        }

        // Tag가 Player 일때만 충돌하게 코드를 작성해보세요.

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Player"))
            {
                collision.gameObject.SetActive(false);
            }

            if (collision.collider.CompareTag("NonDisable"))
            {
                Destroy(gameObject);
            }
        }

    }
}