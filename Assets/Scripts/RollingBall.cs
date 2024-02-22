using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollingBall
{
    public class RollingBall : MonoBehaviour
    {
        [Range(0f, 0.01f)]
        public float speed = 0.003f;
        Vector3 ballPosition;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            ballPosition = new Vector3(0f, 0f, speed);
            transform.position += ballPosition;
        }
    }
}
