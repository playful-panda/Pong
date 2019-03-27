using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingBall : MonoBehaviour {
    private Rigidbody rb;
    public float speed;

    void Start() { 
    
        rb = GetComponent<Rigidbody>();

        float x = Random.Range(-1.0f, 1.0f);
        float y = Random.Range(-1.0f, 1.0f);

        Vector3 direction = new Vector3(x, 0f, y) * speed;

        rb.AddForce(direction, ForceMode.Impulse);
    }

    void Update() {

    }
}