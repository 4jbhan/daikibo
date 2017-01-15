using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyBotton : MonoBehaviour {

    public static bool pvp1;

    public void OnClick(int number) {
        //number = 0 : pvp , number = 1 : pvc
        if (number == 0)
        {
            pvp1 = true;
            SceneManager.LoadScene("gra");
        }
        else if(number == 1){
            pvp1 = false;
            SceneManager.LoadScene("gra");
        }else if(number == 2)
        {
            Application.Quit();
        }
        
    }

    public static bool RetPvp()
    {
        return pvp1;
    }
}
