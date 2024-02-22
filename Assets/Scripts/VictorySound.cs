using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictorySound : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource victorySound;
    bool play;
    void Start()
    {
        victorySound = GetComponent<AudioSource>();
        play = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= 6.74 & play == false )
        {
            victorySound.Play();
        }
        play = victorySound.isPlaying ? true : false;
    }
}
