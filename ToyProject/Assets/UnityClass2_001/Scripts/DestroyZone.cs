using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class DestroyZone : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);
        }
    }
}
