using UnityEngine;
using System.Collections;

public class C : MonoBehaviour {
    public UserInterface hand;
    public raw_position cord;

    // Use this for initialization
    void Start () {
        hand = GetComponent<UserInterface>();
        cord = GetComponent<raw_position>();
        cord.setter();
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
