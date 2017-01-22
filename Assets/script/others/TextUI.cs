using UnityEngine;
using System.Collections;

public class TextUI : MonoBehaviour {
    Game_Master gm;
	// Use this for initialization
	void Start () {
        gm = GetComponent<Game_Master>();
	}
	
	void onGUI()
    {
        float sw = Screen.width;
        float sh = Screen.height;

        GUI.TextField(new Rect(10, 10, 10, 10), "Test");

        if (gm.eturn)
        {
            GUI.TextField(new Rect(sw, sw, sw/10, sh/10),"Red Player Turn");
        }

        if (!gm.eturn)
        {
            GUI.TextField(new Rect(sw, sw, sw / 10, sh / 10), "Blue Player Turn");
        }
    }
}
