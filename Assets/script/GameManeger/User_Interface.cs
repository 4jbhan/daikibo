using UnityEngine;
using System.Collections;

public class User_Interface : MonoBehaviour
{

    // 左クリックされた場所のオブジェクトを取得
    public GameObject getClickObject()
    {
        GameObject result = null;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray, out hit))
            {
                result = hit.collider.gameObject;
            }
        }
        return result;
    }
}