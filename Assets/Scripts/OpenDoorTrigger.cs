using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorTrigger : MonoBehaviour
{
    private Animation animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponentInParent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animation.Play("OpenDoor");
        }
    }
}
