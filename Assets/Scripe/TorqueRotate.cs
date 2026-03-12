using System;
using UnityEngine;

public class TorqueRotate : MonoBehaviour
{
    public float TorquePower;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.AddTorque(new Vector3(0, TorquePower, 0));
    }
}
