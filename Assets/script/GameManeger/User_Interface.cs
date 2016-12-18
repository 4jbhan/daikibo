using UnityEngine;
using System.Collections;

public class User_Interface : MonoBehaviour
{
    public float distance = 100f;
    public Object_Mover o_mov;

    // Use this for initialization
    void Start()
    {
        o_mov = GetComponent<Object_Mover>();
    }

    public GameObject getClickObject()
    {
        GameObject result = null;
        // 左クリックされた場所のオブジェクトを取得
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

    public void MrkGenerator(crystat cry_stat,int[,] CryPosition)
    {
        int[,] MrkCheck = new int[8, 8];

        switch (cry_stat.owntag)
        {
            case 0:
                o_mov.MrkKing(CryPosition, MrkCheck, cry_stat.x, cry_stat.y);
                break;
            case 1:
                o_mov.MrkQueen(CryPosition, MrkCheck, cry_stat.x, cry_stat.y);
                break;
            case 2:
                o_mov.MrkBishop(CryPosition, MrkCheck, cry_stat.x, cry_stat.y);
                break;
            case 3:
                o_mov.MrkKnight(CryPosition, MrkCheck, cry_stat.x, cry_stat.y);
                break;
            case 4:
                o_mov.MrkRook(CryPosition, MrkCheck, cry_stat.x, cry_stat.y);
                break;
            case 5:
                o_mov.MrkPawn(CryPosition,MrkCheck,cry_stat.x, cry_stat.y);

                break;
        }
        o_mov.MrkMaker(MrkCheck);
    }
}


