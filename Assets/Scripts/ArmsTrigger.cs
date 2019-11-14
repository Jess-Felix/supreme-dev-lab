using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmsTrigger : MonoBehaviour
{
    private SkinnedMeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponentInParent<SkinnedMeshRenderer>();
        meshRenderer.enabled = false;
    }
 
    // Update is called once per frame
    void Update()
    {
       
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            meshRenderer.enabled = true;
        }
    }
}
