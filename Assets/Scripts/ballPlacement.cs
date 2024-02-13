using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballPlacement : MonoBehaviour
{
    [SerializeField] movePaddle paddle;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 ballVelocity = new Vector2(Random.Range(-300, 300), Random.Range(-300, 300));
        rb.velocity = ballVelocity;

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();       
    }
}
