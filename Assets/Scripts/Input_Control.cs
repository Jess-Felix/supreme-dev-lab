using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Control : MonoBehaviour
{
    public GameObject vrCamera;
    private Rigidbody Rd;


    // Start is called before the first frame update
    void Start()
    {
        Rd = GetComponent<Rigidbody>();            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2")) {
            // this.transform.position += vrCamera.transform.forward * 2 * Time.deltaTime;
            Rd.MovePosition(transform.position + vrCamera.transform.forward * 2 * Time.deltaTime);
            }
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "FallingPlatform")
        {
            transform.position =
                new Vector3(other.transform.position.x, transform.position.y, other.transform.position.z);

        }
    }
}
