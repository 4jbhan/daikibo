using UnityEngine;
using System.Collections;

public class Crystal_Status : MonoBehaviour {
    private int id,hp,atk;




	// Use this for initialization
	void Start () {
	
	}


    public void setter(int _id,int _hp,int _atk)
    {
        id = _id;
        hp = _hp;
        atk = _atk;
    }
	
	
}
