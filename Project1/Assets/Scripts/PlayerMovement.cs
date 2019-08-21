using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        rb.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical) * speed);
        if (Input.GetKeyDown("a"))
        {
            rb.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical) * speed);
        }
        if (Input.GetKeyDown("d"))
        {
            rb.AddForce(new Vector3(moveVertical, 0.0f, moveVertical) * speed);
        }
    }
}
