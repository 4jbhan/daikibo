using UnityEngine;
using System.Collections;

public class Game_Master : MonoBehaviour {
    public Field_Initializer f_init;
    public Data_Initializer d_init;
    public int[,] CryPosition = new int[8, 8];

    // Use this for initialization
    void Start () {
        f_init = GetComponent<Field_Initializer>();
        f_init.PosInit(CryPosition);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
