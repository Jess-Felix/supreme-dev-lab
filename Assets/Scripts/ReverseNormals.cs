using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ReverseNormals : MonoBehaviour
{
    private Mesh mesh;
    // Start is called before the first frame update
    void Start() {
        mesh = GetComponent<MeshFilter>().mesh;
        mesh.triangles = mesh.triangles.Reverse().ToArray();
    }
    
}
