using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCensorEffect : MonoBehaviour
{
    bool isEnabled = false;
    public GameObject pixel;

    public AudioSource paperCrinkles;
    public bool alreadyPlayed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        pixel.transform.gameObject.SetActive(false);

        paperCrinkles = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnabled)
        {
            pixel.transform.gameObject.SetActive(true);


        }

    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            isEnabled = true;

            if (!paperCrinkles.isPlaying && !alreadyPlayed)
            {
                paperCrinkles.Play();
                alreadyPlayed = true;
            }
        }
    }
}
