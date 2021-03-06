﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TestDialog : MonoBehaviour
{

    public ButtonTest test;


    void Start()
    {
        test = this.gameObject.GetComponent<ButtonTest>() as ButtonTest;
    }

    void OnGUI()
    {
       /* var m_guiStyle = new GUIStyle();
        m_guiStyle.fontSize = 30;   // フォントサイズの変更.
        */

        float sw = Screen.width;
        float sh = Screen.height;

        if (test.isOpened)
        {
            GUI.Box(new Rect(sw / 3, sh / 3, sw / 3, sh / 2), "Menu");

            if (GUI.Button(new Rect(sw * 2 / 5, sh * 2 / 5, sw / 5, sh / 10), "Go to Start Menu"))
            {
             
                SceneManager.LoadScene("Title");
                test.isOpened = false;
                Destroy(this);
            }

            if (GUI.Button(new Rect(sw * 2 / 5, sh * 11 / 20, sw / 5, sh / 10), "Go to Development View"))
            {
                SceneManager.LoadScene("Development");
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