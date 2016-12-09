using UnityEngine;
using System.Collections;

public class B : MonoBehaviour {
    public A a;
    void Start() {
        a = GetComponent<A>();
        a.z = 0;
        a.possetter();
        a.x[5,6] = (float)1;
    }
}
