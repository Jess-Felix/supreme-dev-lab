using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardBehavior : MonoBehaviour
{
    public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.RotateAround(Vector3.up, -45);
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y,transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target, Vector3.up);
    }
}
