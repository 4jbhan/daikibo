using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DevButton : MonoBehaviour
{

    public bool isOpened = false;

    void OnGUI()
    {
        float sw = Screen.width;
        float sh = Screen.height;

        if (GUI.Button(new Rect(0, 0, sw * 3 / 12, sh / 12), "menu") && !isOpened)
        {
            this.gameObject.AddComponent<DevDialog>();
            isOpened = true;
        }

    }
}