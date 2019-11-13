using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTypeAnimation : MonoBehaviour
{
    float originalY;
    bool isEnabled = false;
    public GameObject type;

    void Start()
    {
        
        type.transform.gameObject.SetActive(false);
    }

    void Update()
    {
        if (isEnabled)
        {
            type.transform.gameObject.SetActive(true);

        }

    }
    
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("triggered");
            isEnabled = true;
        }
    }
}
