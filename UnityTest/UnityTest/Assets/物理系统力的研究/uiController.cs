using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiController : MonoBehaviour {

    public GameObject image;
    private Rigidbody2D rb;

    void Start()
    {
        rb = image.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector3(100, 100, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
