using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballPlacement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 ballVelocity = new Vector2(Random.Range(-200, 200), Random.Range(-200, 200));
        rb.velocity = ballVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
