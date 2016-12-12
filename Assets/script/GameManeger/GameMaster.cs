using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
    //int[,] curCryPosId = new int[8,8];


 //   public Game_initializer initer;
    public Initializer init;

	void Start () {
        //     initer = GetComponent<Game_initializer>();
        //    initer.init_all();
        init = GetComponent<Initializer>();
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
