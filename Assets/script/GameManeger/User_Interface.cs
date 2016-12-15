using UnityEngine;
using System.Collections;

public class User_Interface : MonoBehaviour
{
    public float distance = 100f;

    // Use this for initialization
    void Start()
    {

    }

    public GameObject getClickObject()
    {
        GameObject result = null;
        // 左クリックされた場所のオブジェクトを取得
        if (Input.GetMouseButton(0))
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
