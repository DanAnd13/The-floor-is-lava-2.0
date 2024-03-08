using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwistingMill : MonoBehaviour
{
    public Vector3 rotateChange;
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
        if(isPlaying())
            transform.Rotate(rotateChange);
    }
}
