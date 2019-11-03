using UnityEngine;

public class DissolveJump : MonoBehaviour {

    Material mat;
    Vector3[] floatingPositions;
    int index = 0;
    bool hasJumped = false; 
    bool isEnabled = false;
    private float animationTime = 0.0f;
    
    private void Start() {
        mat = GetComponent<Renderer>().material;

        floatingPositions = new Vector3[4];
        floatingPositions[3] = transform.localPosition;
        floatingPositions[0] = new Vector3(15.83f, 16.116f, -4.753f);
        floatingPositions[1] = new Vector3(15.29f, 16.116f, -6.09f);
        floatingPositions[2] = new Vector3(14.61f, 16.116f, -5.49f);

    }

    private void Update() {
        if (!isEnabled) return;
        
        float dissolveAmount = Mathf.Sin(animationTime) / 2 + 0.5f;
        animationTime += Time.deltaTime *3;
        
        if (dissolveAmount >= 0.99f )  {
            if (!hasJumped) {
                transform.localPosition = floatingPositions[index];
                IncIndex();
                hasJumped = true;
            }
        } else{
            hasJumped = false;
            mat.SetFloat("_DissolveAmount", dissolveAmount);
        }
       
        
    }

    private void IncIndex()
    {
        if (index < floatingPositions.Length -1)
        {
            index++;
        }
        else
        {
            index=0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            isEnabled = true;
        }
    }
    }