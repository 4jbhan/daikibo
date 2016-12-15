using UnityEngine;
using System.Collections;

public class C : MonoBehaviour {
    public User_Interface u_i;
    public raw_position r_pos;

    // Use this for initialization
    void Start () {
        u_i = GetComponent<User_Interface>();
        r_pos = GetComponent<raw_position>();
        r_pos.setter();
    }

    void FixedUpdate()
    {
        if (u_i.getClickObject() != null)
        {
            GameObject Objective = u_i.getClickObject();
            if (Objective.GetComponent<Rigidbody>() != null)
            {
                Rigidbody rigid = Objective.GetComponent<Rigidbody>();
                rigid.GetComponent<Rigidbody>().MovePosition(r_pos.rawPosition[4, 4]);
            }
        }        
    }
}
