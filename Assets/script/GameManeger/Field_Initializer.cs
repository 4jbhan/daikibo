using UnityEngine;
using System.Collections;

public class Field_Initializer : MonoBehaviour {
    public Object_Mover o_mov;
    public Data_Initializer d_init;
    // Use this for initialization
    void Start () {
        o_mov = GetComponent<Object_Mover>();
        d_init = GetComponent<Data_Initializer>();
    }
	
	public void PosInit(int[,] CryPosition)
    {
        d_init.PosSetter(CryPosition);
        o_mov.ArraytoPos(CryPosition);
    }    
}
