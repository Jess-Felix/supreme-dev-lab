using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDoorCollider : MonoBehaviour
{
    public AudioSource doorcolliderAudio;


    void Start()
    {
        doorcolliderAudio = GetComponent<AudioSource>();
        doorcolliderAudio.Play();

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            doorcolliderAudio.Stop();
        }
    }
}
