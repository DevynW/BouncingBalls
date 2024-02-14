using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class movePaddle : MonoBehaviour
{
    [SerializeField] float speed = .3f;
    [SerializeField] bool paddleSelect = true;
    public int score = 0;
    public TextMeshProUGUI Score;
    bool colorBool = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (paddleSelect == true)
        {
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 145)
            {
                transform.Translate(speed * Vector3.up, Space.World);
            }
            if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -145)
            {
                transform.Translate(speed * Vector3.down, Space.World);
            }
        }
        else if (paddleSelect == false)
        {
            if (Input.GetKey(KeyCode.W) && transform.position.y < 145)
            {
                transform.Translate(speed * Vector3.up, Space.World);
            }
            if (Input.GetKey(KeyCode.S) && transform.position.y > -145)
            {
                transform.Translate(speed * Vector3.down, Space.World);
            }
        }
    }

    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (colorBool == true) 
        {
            colorBool = false;
        }
        else if (colorBool ==  false) 
        {
            colorBool = true;
        }
        score++;
        if (paddleSelect == true)
        {
            Debug.Log("Satelite 2: " + score);
            Score.text = "Satelite 2: " + score;
        }
        else if (paddleSelect == false)
        {
            Debug.Log("Satelite 1: " + score);
            Score.text = "Satelite 1: " + score;
        }
        SpriteRenderer ballsprite = collision.gameObject.GetComponent<SpriteRenderer>();
             if (colorBool == true)
                { ballsprite.color = Color.white; }
             else if (colorBool == false)
                {ballsprite.color = Color.red; }
    }
}
