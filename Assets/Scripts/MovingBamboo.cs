using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingBamboo : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    public int playerNumber;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float direction = Input.GetAxis(string.Concat("Joy", playerNumber));

        Vector3 movement = new Vector3(0.0f, 0.0f, direction);

        rb.AddForce(movement * speed);

    }
}
