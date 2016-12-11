using UnityEngine;
using System.Collections;

public class C : MonoBehaviour {
    public click_test hand;
    Vector3 trans_objective = new Vector3((float)1.301124, (float)10.80, (float)3.141190);
    public raw_position cord;

    // Use this for initialization
    void Start () {
        hand = GetComponent<click_test>();
        cord = GetComponent<raw_position>();
        cord.data_setter();
    }
	
	// Update is called once per frame
	void Update () {
  /*      GameObject mission_objective;
        if (hand.getClickObject() != null)
        {
            mission_objective = hand.getClickObject();
            Rigidbody are = mission_objective.GetComponent<Rigidbody>();

            if (mission_objective != null)
            {
                string objectName = mission_objective.name;
                Debug.Log(objectName);
            }

        }
        */
              
      
   }

    void FixedUpdate()
    {
        GameObject mission_objective;
        if (hand.getClickObject() != null)
        {
            mission_objective = hand.getClickObject();
            if (mission_objective.GetComponent<Rigidbody>() != null)
            {
                Rigidbody are = mission_objective.GetComponent<Rigidbody>();

                are.GetComponent<Rigidbody>().MovePosition(cord.cordinates[4, 4]);
            }
        }

        
    }
}
