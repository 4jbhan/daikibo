using UnityEngine;
using System.Collections;

public class Pos_change : MonoBehaviour {

    Vector3 tra_obj = new Vector3((float)0.08149733, (float)4.092494, (float)-9.08974);
    int f = 0;
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButton(0))
        {
            f = 1;
        }
	}

    void FixedUpdate()
    {
        if (f == 1)
        {
            GetComponent<Rigidbody>().MovePosition(tra_obj);
        }
    }
}
