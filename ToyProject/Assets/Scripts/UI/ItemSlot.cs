using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ClassStudy
{
    [CreateAssetMenu(fileName ="ItemSlot", menuName = "SlotMaker")]
    public class ItemSlot : ScriptableObject
    {
        public Sprite[] images;
    }
}
