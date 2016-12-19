using UnityEngine;
using System.Collections;

public class User_Interface : MonoBehaviour
{
    private float distance = 100f;
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

    public void MrkGenerator(Crystal_Status crystat,int[,] CryPosition)
    {
        int[,] MrkCheck = new int[8, 8];

        switch (crystat.owntag)
        {
            case 0:
                o_mov.MrkKing(CryPosition, MrkCheck, crystat.x, crystat.y);
                break;
            case 1:
                o_mov.MrkQueen(CryPosition, MrkCheck, crystat.x, crystat.y);
                break;
            case 2:
                o_mov.MrkBishop(CryPosition, MrkCheck, crystat.x, crystat.y);
                break;
            case 3:
                o_mov.MrkKnight(CryPosition, MrkCheck, crystat.x, crystat.y);
                break;
            case 4:
                o_mov.MrkRook(CryPosition, MrkCheck, crystat.x, crystat.y);
                break;
            case 5:
                o_mov.MrkPawn(CryPosition,MrkCheck,crystat.x, crystat.y);

                break;
        }
        o_mov.MrkMaker(MrkCheck);
    }

    public bool PawnCheck(Crystal_Status attcker, Crystal_Status defender)
    {
        if (defender.y == attcker.y+1 &&(defender.x == (attcker.x+1)%8 || defender.x == (attcker.x + 7)%8))
        {
            return true;
        }

        return false;
    }

    public bool RookCheck(Crystal_Status attcker, Crystal_Status defender)
    {
        if (defender.y == attcker.y && (defender.x == (attcker.x + 1)%8 || defender.x == (attcker.x + 7)%8))
        {
            return true;
        }

        if (defender.x == attcker.x && (defender.y == attcker.y + 1 || defender.y == attcker.y))
        {
            return true;
        }

        return false;
    }

    public bool KnightCheck(Crystal_Status attcker, Crystal_Status defender)
    {
        if (defender.y == attcker.y && (defender.x == (attcker.x + 1) % 8 || defender.x == (attcker.x + 7) % 8))
        {
            return true;
        }

        if (defender.x == attcker.x && (defender.y == attcker.y + 1 || defender.y == attcker.y))
        {
            return true;
        }

        return false;
    }

    public bool BishopCheck(Crystal_Status attcker, Crystal_Status defender)
    {
        if (defender.y == attcker.y+1 && (defender.x == (attcker.x + 1)%8 || defender.x == (attcker.x + 7)%8))
        {
            return true;
        }

        if (defender.y == attcker.y - 1 && (defender.x == (attcker.x + 1) % 8 || defender.x == (attcker.x + 7) % 8))
        {
            return true;
        }

        return false;
    }

    public bool QueenCheck(Crystal_Status attcker, Crystal_Status defender)
    {
        if (defender.y == attcker.y && (defender.x == (attcker.x + 1) % 8 || defender.x == (attcker.x + 7) % 8))
        {
            return true;
        }

        if (defender.x == attcker.x && (defender.y == attcker.y + 1 || defender.y == attcker.y))
        {
            return true;
        }

        if (defender.y == attcker.y + 1 && (defender.x == (attcker.x + 1) % 8 || defender.x == (attcker.x + 7) % 8))
        {
            return true;
        }

        if (defender.y == attcker.y - 1 && (defender.x == (attcker.x + 1) % 8 || defender.x == (attcker.x + 7) % 8))
        {
            return true;
        }

        return false;
    }

    public bool KingCheck(Crystal_Status attcker, Crystal_Status defender)
    {
        if (defender.y == attcker.y && (defender.x == (attcker.x + 1) % 8 || defender.x == (attcker.x + 7) % 8))
        {
            return true;
        }

        if (defender.x == attcker.x && (defender.y == attcker.y + 1 || defender.y == attcker.y))
        {
            return true;
        }

        if (defender.y == attcker.y + 1 && (defender.x == (attcker.x + 1) % 8 || defender.x == (attcker.x + 7) % 8))
        {
            return true;
        }

        if (defender.y == attcker.y - 1 && (defender.x == (attcker.x + 1) % 8 || defender.x == (attcker.x + 7) % 8))
        {
            return true;
        }

        return false;
    }

    public bool AtkCheck(Crystal_Status attcker, Crystal_Status defender)
    {
        switch (attcker.owntag)
        {
            case 0:
                return KingCheck(attcker,defender);
            case 1:
                return QueenCheck(attcker, defender);
            case 2:
                return BishopCheck(attcker, defender);
            case 3:
                return KnightCheck(attcker, defender);
            case 4:
                return RookCheck(attcker, defender);
            case 5:
                return PawnCheck(attcker, defender);
        }

        return false;
    }

    public bool canKingCheck(Crystal_Status attcker, int[,] CryPosition)
    {
        if (attcker.y + 1 < 8 && CryPosition[attcker.y+1, attcker.x] > 16)
        {
            return true;
        }
        if (attcker.y + 1 < 8 && CryPosition[attcker.y + 1, (attcker.x + 1) % 8] > 16)
        {
            return true;
        }
        if (attcker.y + 1 < 8 && CryPosition[attcker.y + 1, (attcker.x + 7) % 8] > 16)
        {
            return true;
        }
        if (CryPosition[attcker.y, (attcker.x + 1) % 8] > 16)
        {
            return true;
        }
        if (CryPosition[attcker.y, (attcker.x + 7) % 8] > 16)
        {
            return true;
        }
        if (attcker.y - 1 >= 0 && CryPosition[attcker.y - 1, attcker.x] > 16)
        {
            return true;
        }
        if (attcker.y - 1 >= 0 && CryPosition[attcker.y - 1, (attcker.x + 1) % 8] > 16)
        {
            return true;
        }
        if (attcker.y - 1 >= 0 && CryPosition[attcker.y - 1, (attcker.x + 7) % 8] > 16)
        {
            return true;
        }

        return false;
    }

    public bool canQueenCheck(Crystal_Status attcker, int[,] CryPosition)
    {
        if (attcker.y + 1 < 8 && CryPosition[attcker.y + 1, attcker.x] > 16)
        {
            return true;
        }
        if (attcker.y + 1 < 8 && CryPosition[attcker.y + 1, (attcker.x + 1) % 8] > 16)
        {
            return true;
        }
        if (attcker.y + 1 < 8 && CryPosition[attcker.y + 1, (attcker.x + 7) % 8] > 16)
        {
            return true;
        }
        if (CryPosition[attcker.y, (attcker.x + 1) % 8] > 16)
        {
            return true;
        }
        if (CryPosition[attcker.y, (attcker.x + 7) % 8] > 16)
        {
            return true;
        }
        if (attcker.y - 1 >= 0 && CryPosition[attcker.y - 1, attcker.x] > 16)
        {
            return true;
        }
        if (attcker.y - 1 >= 0 && CryPosition[attcker.y - 1, (attcker.x + 1) % 8] > 16)
        {
            return true;
        }
        if (attcker.y - 1 >= 0 && CryPosition[attcker.y - 1, (attcker.x + 7) % 8] > 16)
        {
            return true;
        }

        return false;
    }

    public bool canBishopCheck(Crystal_Status attcker, int[,] CryPosition)
    {
        if (attcker.y + 1 < 8 && CryPosition[attcker.y + 1, (attcker.x + 1) % 8] > 16)
        {
            return true;
        }
        if (attcker.y + 1 < 8 && CryPosition[attcker.y + 1, (attcker.x + 7) % 8]  > 16)
        {
            return true;
        }
        
        if (attcker.y - 1 >= 0 && CryPosition[attcker.y - 1, (attcker.x + 1) % 8] > 16)
        {
            return true;
        }
        if (attcker.y - 1 >= 0 && CryPosition[attcker.y - 1, (attcker.x + 7) % 8] > 16)
        {
            return true;
        }

        return false;
    }

    public bool canKnightCheck(Crystal_Status attcker, int[,] CryPosition)
    {
        if (attcker.y + 1 < 8 && CryPosition[attcker.y + 1, attcker.x] > 16)
        {
            return true;
        }

        if (CryPosition[attcker.y, (attcker.x + 1) % 8] > 16)
        {
            return true;
        }
        if (CryPosition[attcker.y, (attcker.x + 7) % 8] > 16)
        {
            return true;
        }
        if (attcker.y - 1 >= 0 && CryPosition[attcker.y - 1, attcker.x] > 16)
        {
            return true;
        }

        return false;
    }

    public bool canRookCheck(Crystal_Status attcker, int[,] CryPosition)
    {
        if (attcker.y + 1 < 8 && CryPosition[attcker.y + 1, attcker.x] > 16)
        {
            return true;
        }

        if (CryPosition[attcker.y, (attcker.x + 1) % 8] > 16)
        {
            return true;
        }
        if (CryPosition[attcker.y, (attcker.x + 7) % 8] > 16)
        {
            return true;
        }
        if (attcker.y - 1 >= 0 && CryPosition[attcker.y - 1, attcker.x] > 16)
        {
            return true;
        }

        return false;
    }

    public bool canPawnCheck(Crystal_Status attcker, int[,] CryPosition)
    {
        if (attcker.y + 1 < 8 && CryPosition[attcker.y+1, (attcker.x + 1) % 8] > 16)
        {
            return true;
        }
        if (attcker.y + 1 < 8 && CryPosition[attcker.y+1, (attcker.x + 7) % 8] > 16)
        {
            return true;
        }
        return false;
    }

    public bool canAtkCheck(Crystal_Status attcker,int[,] CryPosition)
    {
        switch (attcker.owntag)
        {
            case 0:
                return canKingCheck(attcker, CryPosition);
            case 1:
                return canQueenCheck(attcker, CryPosition);
            case 2:
                return canBishopCheck(attcker, CryPosition);
            case 3:
                return canKnightCheck(attcker, CryPosition);
            case 4:
                return canRookCheck(attcker, CryPosition);
            case 5:
                return canPawnCheck(attcker, CryPosition);
        }

        return false;
    }

}


