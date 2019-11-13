using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeAnimation : MonoBehaviour
{
    public Transform target;
    public float speed = 1.0f;
    private bool isEnabled = true, isFollowingTarget = false;
    private float timecounted = 0f;
    public float rotationSpeed = 160f;
    public float rotationRadius = 0.45f;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(target.position);
        if (isEnabled)
        {
            timecounted += Time.deltaTime;
            Debug.Log("counting");
        }

        if (timecounted >= 1.5f && !isFollowingTarget) isFollowingTarget = true;

        if (isFollowingTarget)
        {
            if (Vector3.Distance(transform.position, target.position) > rotationRadius)
            {
                float step = speed * Time.deltaTime; // calculate distance to move
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
            else
            {
                transform.position = RotateAroundPivot(transform.position, target.position,
                    Quaternion.Euler(0, rotationSpeed*Time.deltaTime, 0));
            }

        }
    }

    private Vector3 RotateAroundPivot(Vector3 point, Vector3 pivot, Quaternion angle)
    {
        return angle * (point - pivot) + pivot;
    }

}
