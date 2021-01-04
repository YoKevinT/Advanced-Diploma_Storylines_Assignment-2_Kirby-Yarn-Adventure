using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    // Expressions
    public Animator expression2;
    public Animator expression8;
    public Animator expression9;

    // Actions
    public Animator apple1;
    public Animator walking3;
    public Animator walking4;
    public Animator looking5;
    public Animator walking6;
    public Animator walking7;

    // Camera
    public Animator camera0;

    void Start()
    {
        // Expressions
        expression2.enabled = false;
        expression8.enabled = false;
        expression9.enabled = false;

        // Actions
        apple1.enabled = false;
        walking3.enabled = false;
        walking4.enabled = false;
        looking5.enabled = false;
        walking6.enabled = false;
        walking7.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            camera0.Play("Camera1");

            if (apple1.enabled == false)
            {
                apple1.enabled = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            camera0.Play("Camera2");

            // Play expression and stop the apple animation
            expression2.gameObject.SetActive(true);

            if (expression2.enabled == false)
            {
                expression2.enabled = true;

                if (apple1.enabled == true)
                {
                    apple1.enabled = false;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            camera0.Play("Camera3");

            if (walking3.enabled == false)
            {
                walking3.enabled = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            camera0.Play("Camera4");

            if (walking4.enabled == false)
            {
                walking4.enabled = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            camera0.Play("Camera5");

            if (looking5.enabled == false)
            {
                looking5.enabled = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            camera0.Play("Camera6");

            if (walking6.enabled == false)
            {
                walking6.enabled = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            camera0.Play("Camera7");

            if (walking7.enabled == false)
            {
                walking7.enabled = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            camera0.Play("Camera8");

            // Play expression
            expression8.gameObject.SetActive(true);

            if (expression8.enabled == false)
            {
                expression8.enabled = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            camera0.Play("Camera9");

            // Play expression
            expression9.gameObject.SetActive(true);

            if (expression9.enabled == false)
            {
                expression9.enabled = true;
            }
        }
    }
}