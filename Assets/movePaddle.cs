using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class movePaddle : MonoBehaviour
{
    [SerializeField] float speed = .3f;
    [SerializeField] bool paddleSelect = true;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (paddleSelect == true)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(speed * Vector3.up, Space.World);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(speed * Vector3.down, Space.World);
            }
        }
        else if (paddleSelect == false)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(speed * Vector3.up, Space.World);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(speed * Vector3.down, Space.World);
            }
        }
    }

    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        score++;
        if (paddleSelect == true)
        {
            Debug.Log("Satelite 2: " + score);
        }
        else if (paddleSelect == false)
        {
            Debug.Log("Satelite 1: " + score);
        }
    }
}
