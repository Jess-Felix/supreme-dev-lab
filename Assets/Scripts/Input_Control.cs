using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Control : MonoBehaviour
{
    public GameObject vrCamera;
    private Rigidbody Rd;
    public AudioSource walkingAudio;


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
            Rd.MovePosition(transform.position + vrCamera.transform.forward * 2 * Time.deltaTime);

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
}
