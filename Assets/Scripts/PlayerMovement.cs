using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;
    }
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.A)) rb.AddForce(Vector3.left * speed);
        if (Input.GetKey(KeyCode.D)) rb.AddForce(Vector3.right *speed);
        if (Input.GetKey(KeyCode.W)) rb.AddForce(Vector3.forward * speed);
        if (Input.GetKey(KeyCode.S)) rb.AddForce(Vector3.back * speed);

    }

    void FixedUpdate()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.A)) move += Vector3.left;
        if (Input.GetKey(KeyCode.D)) move += Vector3.right;
        if (Input.GetKey(KeyCode.W)) move += Vector3.forward;
        if (Input.GetKey(KeyCode.S)) move += Vector3.back;

        rb.AddForce(move.normalized * speed);
    }
}