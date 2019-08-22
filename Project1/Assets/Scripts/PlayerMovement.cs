using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 2.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical) * speed);
    }
}