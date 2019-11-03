using UnityEngine;

public class DissolveJump : MonoBehaviour {

    Material mat;
    Vector3[] floatingPositions;
    int index = 0;
    bool hasJumped = false;
    
    private void Start() {
        mat = GetComponent<Renderer>().material;

        floatingPositions = new Vector3[4];
        floatingPositions[0] = transform.localPosition;
        floatingPositions[1] = new Vector3(15.83f, 16.116f, -4.753f);
        floatingPositions[2] = new Vector3(15.29f, 16.116f, -6.09f);
        floatingPositions[3] = new Vector3(14.61f, 16.116f, -5.49f);

    }

    private void Update() {
        float dissolveAmount = Mathf.Sin(Time.time) / 2 + 0.5f;

        if (dissolveAmount >= 0.99f)  {
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
}