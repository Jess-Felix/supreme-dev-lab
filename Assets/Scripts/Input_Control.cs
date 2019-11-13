﻿
using UnityEngine;

public class Input_Control : MonoBehaviour
{
    public GameObject vrCamera;
    private Rigidbody Rd;
    public AudioSource walkingAudio;
    public float playerSpeed = 2.4f;

    // Start is called before the first frame update
    void Start()
    {
        Rd = GetComponent<Rigidbody>();
        walkingAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2")) {
            // this.transform.position += vrCamera.transform.forward * 2 * Time.deltaTime;
            Rd.MovePosition(transform.position + playerSpeed * Time.deltaTime * vrCamera.transform.forward);

            if (!walkingAudio.isPlaying)
            {
                walkingAudio.Play();
            }

        }
        else
        {
            walkingAudio.Stop();
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
