using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ClassStudy
{
    public class MenuController : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void GameStart()
        {
                                       // 0¹ø ¾À intro Scene - 1¹ø ¾À Main Game Scene
            SceneManager.LoadScene(1); // Scene¿¡ 1¹ø ÀÎµ¦½º¸¦ ºÒ·¯¿Í¶ó.
        }
    }
}
