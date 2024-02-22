using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingCamera : MonoBehaviour
{
    public Vector3 positionChange;
    public Vector3 finishPosition = new Vector3(1.65f, 14.41532f, -1.817962f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 14.41532f & transform.position.z >= -1.817962f)
            transform.position = finishPosition;
        else
            transform.position += positionChange;
    }
}
