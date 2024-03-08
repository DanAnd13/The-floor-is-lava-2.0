using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class MovingCamera : MonoBehaviour
    {
        public Vector3 positionChange;
        public Vector3 finishPosition = new Vector3(1.65f, 14.41532f, -1.817962f);
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

        // Update is called once per frame
        void Update()
        {
            if (isPlaying())
            {
                if (transform.position.y >= 14.41532f & transform.position.z >= -1.817962f)
                    transform.position = finishPosition;
                else
                    transform.position += positionChange;
            }
        }
    }
