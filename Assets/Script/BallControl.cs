using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float Velocity = 300f;

    private Rigidbody ballRigidBody = null;
    void Awake()
    {
        ballRigidBody = GetComponent<Rigidbody>();
        transform.parent = null;
        ballRigidBody.isKinematic = false;
        ballRigidBody.AddForce(Velocity, Velocity*1.5f, 0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
