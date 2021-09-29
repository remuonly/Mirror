using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    public float speed;
    private Rigidbody rb;
    private void Start()
    {
        if (isLocalPlayer)
        {
            GameObject.Find("Main Camera").GetComponent<CamerController>().player = gameObject.transform;
        }
        rb = GetComponent<Rigidbody>();
    }
    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float moveVertical = Input.GetAxis("Vertical");
            float moveHorizontal = Input.GetAxis("Horizontal");
            Vector3 moveMent = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.AddForce(moveMent * speed);
        }
    }

    [Command]
    void helo()
    {
        Debug.Log("received helo message from client!");
    }

    void Update()
    {
        // HandleMovement();
        if (isLocalPlayer && Input.GetKeyDown("x"))
        {
            Debug.Log("sending helo message to server!");
            helo();
        }
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }
}
