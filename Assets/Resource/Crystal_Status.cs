using UnityEngine;
using System.Collections;

public class Crystal_Status : MonoBehaviour {
    public int hp;
    public int atk;
    public int x;
    public int y;
    public string personal;
    public int owntag;
    public bool iff;
     
	public void setter(int hitpoint,int atack,int iy, int ix,string name,int tag, bool who)
    {
        hp = hitpoint;
        atk = atack;
        x = ix;
        y = iy;
        personal = name;
        owntag = tag;
        iff = who;
    }

}
