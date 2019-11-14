using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatForward : MonoBehaviour
{
    float originalZ;

    public float floatStrength = 1; // You can change this in the Unity Editor to 
    // change the range of y positions that are possible.

    void Start()
    {
        this.originalZ = this.transform.position.z;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x,
           transform.position.y, originalZ + ((float)System.Math.Sin(Time.time) * floatStrength));
    }
}