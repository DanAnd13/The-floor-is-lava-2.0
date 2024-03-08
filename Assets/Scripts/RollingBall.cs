using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RollingBall
{
    public class RollingBall : MonoBehaviour
    {
        [Range(0f, 0.01f)]
        public float speed = 0.003f;
        Vector3 ballPosition;
        public Button playButton;
        public Button stopButton;
        public Image menu;
        public bool isPlaying()
        {
            if (playButton.IsActive())
                return false;
            else if (stopButton.IsActive())
                return true;
            else if (menu.IsActive())
                return false;
            else return false;
        }
            void Start()
        {
            
        }
        void Update()
        {
            if (isPlaying())
            {
                ballPosition = new Vector3(0f, 0f, speed);
                transform.position += ballPosition;
            }
        }
    }
}
