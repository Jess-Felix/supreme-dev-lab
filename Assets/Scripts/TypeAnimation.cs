using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeAnimation : MonoBehaviour
{
    public Transform target;
    public float speed = 1.0f;
    private bool isEnabled = true;
    private float timecounted = 0f;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnabled)
        {
            timecounted += Time.deltaTime;
            Debug.Log("counting");
        }

        if (timecounted >= 2.5f)
        { 
            float step =  speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }
}
