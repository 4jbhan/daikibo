using UnityEngine;
using System.Collections;

public class A : MonoBehaviour {
    public int z = 9;
    public float[,] x = new float[8, 8];
    public Vector3[,] y = new Vector3[8, 8];

    public void possetter()
    {
        x[0,0] = 0;
    }
}
