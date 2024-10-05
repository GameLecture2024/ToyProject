using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Falling : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            // Tag�� NonDisable�̸� �浹���� ����. �� �ڵ带 �ۼ����� ������
            if(collision.collider.CompareTag("NonDisable"))
            {
                return;
            }

            // �����е��� ���� �±׸� �ϳ� ��������.
            
            // MyTag 

            Debug.Log(collision.gameObject.name);  // �浹�� ������Ʈ�� �̸� ���
            collision.gameObject.SetActive(false); // �浹�� ������Ʈ�� ��Ȱ��ȭ
            


        }

        private void OnCollisionExit(Collision collision)
        {
            
        }

        private void OnCollisionStay(Collision collision)
        {
            
        }
    }
}
