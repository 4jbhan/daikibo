using UnityEngine;
using System.Collections;

public class ButtonTest : MonoBehaviour
{

    public bool isOpened = false;

    void OnGUI()
    {
        float sw = Screen.width;
        float sh = Screen.height;

        if (GUI.Button(new Rect(0, 0, sw * 3 / 12, sh / 12), "Menu") && !isOpened)
        {
            this.gameObject.AddComponent<TestDialog>();
            isOpened = true;
        }

    }
}