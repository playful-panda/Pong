using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingBamboo : MonoBehaviour {
    private Rigidbody rb;
    public float speed;

    // Start is called before the first frame update

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
    
        float direction = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0.0f, 0.0f, direction);

        rb.AddForce(movement * speed);

    }
}
