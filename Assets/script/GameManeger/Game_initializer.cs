using UnityEngine;
using System.Collections;

public class Game_initializer : MonoBehaviour {
    public cordinates_setter c_s;
    public temp_initpos t_ip;
    // Use this for initialization
    void Start () {
        c_s = GetComponent<cordinates_setter>();
        t_ip = GetComponent<temp_initpos>();
        t_ip.setter();
        c_s.array_t_opos(t_ip.initpos);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void pos_init()
    {

    }
}
