using UnityEngine;
using System.Collections;

public class Initializer : MonoBehaviour {
    public Field_Initializer f_i;
    public Data_Initializer d_i;
    public int[,] curCryPosId = new int[8, 8];

	// Use this for initialization
	void Start () {
        f_i = GetComponent<Field_Initializer>();
        f_i._fPosInitializer(curCryPosId);
	}
	
}
