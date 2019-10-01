using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;
    public bool isGrounded;
    public Vector3 jump;

    public float jumpForce = 2.0f;
    Rigidbody rb;

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 3.0f, 0.0f);
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector3.forward / 5) * speed);


        if (Input.GetKeyDown(KeyCode.A))
        {

            transform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

    }
}
