using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce = 3f;

    public float tiltTime = 10f;
    public float fallThreshold = 3f;

    Vector2 dir;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();

        ControlLookDir();
    }

    void MyInput()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void ControlLookDir()
    {
        if(rb.velocity.y < fallThreshold)
        {
            rb.rotation = Mathf.Lerp(rb.rotation, -45f, tiltTime * Time.deltaTime);
        }
    }
}
