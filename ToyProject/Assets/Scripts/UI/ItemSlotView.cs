using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ClassStudy
{
    public class ItemSlotView : MonoBehaviour
    {
        public ItemSlot slot;

        public Image[] images;

        public ItemSlotController controller;


        private void OnEnable()
        {
            controller.UpdateUICallback += InitImage;
        }

        private void OnDisable()
        {
            controller.UpdateUICallback -= InitImage;
        }


        private void InitImage()
        {
            for (int i = 0; i < images.Length; i++)
            {
                images[i].sprite = slot.images[i];
            }
        }
    }
}
