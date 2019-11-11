using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScene : MonoBehaviour

{
    public AudioSource doorAudio;


    // Start is called before the first frame update
    void Start()
    {

        doorAudio = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
       
        if (other.tag == "Player"){
            if (!doorAudio.isPlaying)
            {
                doorAudio.Play();
            }

            switch (SceneManager.GetActiveScene().name)
            {
                case "FirstRoom":
                    SceneManager.LoadScene("ThirdRoom");
                break;

                case "ThirdRoom":
                    SceneManager.LoadScene("FourthCorridor");
                    break;

                case "FourthCorridor":
                    SceneManager.LoadScene("FifthCorridor");
                    break;
            }
            DontDestroyOnLoad(this.gameObject);

        }


    }
}
    
