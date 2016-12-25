using UnityEngine;
using System.Collections;

public class Camera_billboard : MonoBehaviour {

	public Camera targetCamera;
	//public TextMesh  Text_HpAtk;

	//public int hp_myking = 6, atk_myking = 8;
	//public int hp_myqueen = 5, atk_myqueen = 7;
	//public int hp_mybishop = 4, atk_mybishop = 6;
	// .....write toward enemypawn

	void Start () {
		if (this.targetCamera == null) 
			targetCamera = Camera.main;	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.LookAt(this.targetCamera.transform.position);
    }
/*
      public void show(Crystal_Status[] crystat)
    {
              if(Text_HpAtk.name == "text_HpAtk1")
                  Text_HpAtk.text = "" + hp_myking + "," + atk_myking;
              else if(Text_HpAtk.name == "text_HpAtk2")
                  Text_HpAtk.text = "" + hp_myqueen + "," + atk_myqueen;
              else if(Text_HpAtk.name == "text_HpAtk3")
                  Text_HpAtk.text = "" + hp_mybishop + "," + atk_mybishop;
              // .....write toward enemypawn
        if (Text_HpAtk.name == "text_HpAtk1")
            Text_HpAtk.text = "H" + crystat[1].hp + ":A" + crystat[1].atk;
    }
*/
}
