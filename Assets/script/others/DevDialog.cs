using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DevDialog : MonoBehaviour {

    public DevButton test;

    void Start()
    {
        test = this.gameObject.GetComponent<DevButton>() as DevButton;
    }

    void OnGUI()
    {
        float sw = Screen.width;
        float sh = Screen.height;

        if (test.isOpened)
        {
            GUI.Box(new Rect(sw / 3, sh / 3, sw / 3, sh / 2), "Menu");

            if (GUI.Button(new Rect(sw * 2 / 5, sh * 2 / 5, sw / 5, sh / 10), "Go to Start Menu"))
            {
                Game_Master.first = true;
                SceneManager.LoadScene("Title");
                test.isOpened = false;
                Destroy(this);
            }

            if (GUI.Button(new Rect(sw * 2 / 5, sh * 11 / 20, sw / 5, sh / 10), "Go to Game View"))
            {
                SceneManager.LoadScene("gra");
                test.isOpened = false;
                Destroy(this);
            }

            if (GUI.Button(new Rect(sw * 2 / 5, sh * 14 / 20, sw / 5, sh / 10), "Exit"))
            {
                test.isOpened = false;
                Destroy(this);
                Application.Quit();
            }

            if (GUI.Button(new Rect(sw * 3 / 5, sh * 1 / 3, sw / 20, sh / 20), "×"))
            {
                test.isOpened = false;
                Destroy(this);
            }
        }
    }
}
