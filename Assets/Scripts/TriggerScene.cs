using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScene : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
       
     //   if (other.tag == "Player")

     //   {
      //      SceneManager.LoadScene("ThirdRoom");
     //   }
       
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



    }
}

