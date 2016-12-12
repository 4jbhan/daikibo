using UnityEngine;
using System.Collections;

public class Field_Initializer : MonoBehaviour {
    public Mover mov;
    public Data_Initializer d_a;
    // Use this for initialization
    void Start () {
        mov = GetComponent<Mover>();
        d_a = GetComponent<Data_Initializer>();
    }
	
	public void _fPosInitializer(int[,] curCryPosId)
    {
        d_a._fPosSetter(curCryPosId);
        mov.ArraytoPosition(curCryPosId);
    }    
}
