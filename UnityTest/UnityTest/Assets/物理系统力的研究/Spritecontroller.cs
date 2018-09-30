using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spritecontroller : MonoBehaviour {

    public GameObject SPRITE;
    private Rigidbody2D rb;

    void Start()
    {
        rb = SPRITE.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector3(0, 100, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
