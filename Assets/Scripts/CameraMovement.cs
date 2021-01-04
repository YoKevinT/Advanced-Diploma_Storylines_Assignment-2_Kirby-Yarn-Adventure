using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Now it serves the ParticleSystem Only (The rest is pre-animation)

    //private float speed;
    //public float speedNormal;
    //public float speedPlus;
    public ParticleSystem particles;

    void Start()
    {
        particles.Stop();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightShift))
        {
            //speed = speedPlus;

            if (!particles.isPlaying)
            {
                particles.Play();
            }
        }
        if ((!Input.GetKey(KeyCode.RightShift)))
        {
            //speed = speedNormal;
            particles.Stop();
        }

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        //}
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        //}
    }
}
