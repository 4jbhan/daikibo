using UnityEngine;
using System.Collections;

public class position_move : MonoBehaviour {
   // test_pos posi2 = GameObject.GetComponent<test_pos>(); 
    //Vector3 trans_objective = new Vector3(pos.z, (float)-1.736482, (float)-3.768696);
        Vector3 trans_objective = new Vector3((float)1.301124,(float)10.80,(float)3.141190);
    //    Vector3 trans_objective = new Vector3((float)-1.301124,(float)10.8,(float)3.141190);
    //    Vector3 trans_objective = new Vector3((float)-3.141190,(float)10.8,(float)1.301124);
    //    Vector3 trans_objective = new Vector3((float)-3.141190,(float)10.8,(float)-1.301124);
    //    Vector3 trans_objective = new Vector3((float)-1.301124,(float)10.8,(float)-3.141190);
    //    Vector3 trans_objective = new Vector3((float)1.301124,(float)10.8,(float)-3.141190);
     //   Vector3 trans_objective = new Vector3((float)1.6028,(float)9.4384,(float)-3.2021);
    int f=0;

    
    // Use this for initialization
    void Update() {
        if (Input.GetMouseButton(0))
        {
            f = 1;
        }
    }
	


	// Update is called once per frame
	void FixedUpdate () {
        if (f==1)
        {
            GetComponent<Rigidbody>().MovePosition(trans_objective);
        }
	}
}
