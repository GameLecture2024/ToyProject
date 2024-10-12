using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class ItemSlotController : MonoBehaviour
    {
        public Action UpdateUICallback;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                UpdateUICallback?.Invoke();
            }
        }
    }
}
