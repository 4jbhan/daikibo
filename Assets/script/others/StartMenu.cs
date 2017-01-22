using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {
    public static bool pvp1;


    void OnGUI()
    {
        
        float sw = Screen.width;
        float sh = Screen.height;
        
        if (GUI.Button(new Rect(sw * 2 / 5, sh * 6 / 10, sw / 5, sh / 15), "Player VS Computer"))
        {
            Game_Master.first = true;
            pvp1 = false;
            SceneManager.LoadScene("gra");
        }
        
          
        if (GUI.Button(new Rect(sw * 2 / 5, sh *  7 / 10, sw / 5, sh / 15), "Player VS Player"))
        {
            Game_Master.first = true;
            pvp1 = true;
            SceneManager.LoadScene("gra");
        }

        if (GUI.Button(new Rect(sw * 2 / 5, sh * 4 / 5, sw / 5, sh / 15), "Exit"))
        {
            Application.Quit();
        }

    }

    public static bool RetPvp()
    {
        return pvp1;
    }
}
