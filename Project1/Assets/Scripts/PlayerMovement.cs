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
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)||(Input.GetKey("d")))
        {
            rb.velocity = transform.right * speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow)||(Input.GetKey("a")))
        {
            rb.velocity = -transform.right * speed;
        }
        else if (Input.GetKey(KeyCode.UpArrow)||(Input.GetKey("w")))
        {
            rb.velocity = new Vector3(0, 0, 1) * speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow)||(Input.GetKey("s")))
        {
            rb.velocity = new Vector3(0, 0, -1) * speed;
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
