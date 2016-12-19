using UnityEngine;
using System.Collections;

public class Object_Mover : MonoBehaviour
{
    public GameObject marker;
    //private raw_position r_pos;
    public Data_Initializer d_init;
    // Use this for initialization
    void Start()
    {
      //  r_pos = GetComponent<raw_position>();
       // r_pos.setter();

        d_init = GetComponent<Data_Initializer>();
        d_init.RawPossetter();
    }

    public void ArraytoPos(int[,] CryPosition)
    {

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                string tmp = null;
                switch (CryPosition[i, j])
                {
                    case 1:
                        tmp = "myking";
                        break;
                    case 2:
                        tmp = "myqueen";
                        break;
                    case 3:
                        tmp = "mybishop1";
                        break;
                    case 4:
                        tmp = "mybishop2";
                        break;
                    case 5:
                        tmp = "myknight1";
                        break;
                    case 6:
                        tmp = "myknight2";
                        break;
                    case 7:
                        tmp = "myrook1";
                        break;
                    case 8:
                        tmp = "myrook2";
                        break;
                    case 9:
                        tmp = "mypawn1";
                        break;
                    case 10:
                        tmp = "mypawn2";
                        break;
                    case 11:
                        tmp = "mypawn3";
                        break;
                    case 12:
                        tmp = "mypawn4";
                        break;
                    case 13:
                        tmp = "mypawn5";
                        break;
                    case 14:
                        tmp = "mypawn6";
                        break;
                    case 15:
                        tmp = "mypawn7";
                        break;
                    case 16:
                        tmp = "mypawn8";
                        break;
                    case 17:
                        tmp = "enemyking";
                        break;
                    case 18:
                        tmp = "enemyqueen";
                        break;
                    case 19:
                        tmp = "enemybishop1";
                        break;
                    case 20:
                        tmp = "enemybishop2";
                        break;
                    case 21:
                        tmp = "enemyknight1";
                        break;
                    case 22:
                        tmp = "enemyknight2";
                        break;
                    case 23:
                        tmp = "enemyrook1";
                        break;
                    case 24:
                        tmp = "enemyrook2";
                        break;
                    case 25:
                        tmp = "enemypawn1";
                        break;
                    case 26:
                        tmp = "enemypawn2";
                        break;
                    case 27:
                        tmp = "enemypawn3";
                        break;
                    case 28:
                        tmp = "enemypawn4";
                        break;
                    case 29:
                        tmp = "enemypawn5";
                        break;
                    case 30:
                        tmp = "enemypawn6";
                        break;
                    case 31:
                        tmp = "enemypawn7";
                        break;
                    case 32:
                        tmp = "enemypawn8";
                        break;


                    default:
                        break;
                }
                if (tmp != null)
                {
                    GameObject hand = GameObject.Find(tmp);
                    Rigidbody rigid = hand.GetComponent<Rigidbody>();
                    rigid.GetComponent<Rigidbody>().MovePosition(d_init.rawPosition[i, j]);

                }
            }
        }
    }

    public void MrkMaker(int[,] MrkCheck)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (MrkCheck[i, j] == 1)
                {
                    GameObject tmp = (GameObject)Instantiate(marker, d_init.rawPosition[i, j], Quaternion.identity);
                    tmp.name = i.ToString() + j.ToString() + tmp.name;
                }
            }
        }
    }

    public void MrkRemover()
    {
        var clones = GameObject.FindGameObjectsWithTag("marker");
        foreach (var clone in clones)
        {
            Destroy(clone);
        }
    }


    public void MrkPawn(int[,] CryPosition, int[,] MrkCheck, int x, int y)
    {
        if (y < 7 && CryPosition[y + 1, x] == 0)
        {
            MrkCheck[y + 1, x] = 1;
        }
    }

    public void MrkQueen(int[,] CryPosition, int[,] MrkCheck, int x, int y)
    {
        int yc = y, xc = x;
        while (yc < 7 && CryPosition[yc + 1, xc] == 0 && MrkCheck[yc + 1, xc] == 0)
        {
            MrkCheck[yc + 1, xc] = 1;
            yc++;
        }
        yc = y;
        xc = x;

        while (yc > 0 && CryPosition[yc - 1, xc] == 0 && MrkCheck[yc - 1, xc] == 0)
        {
            MrkCheck[yc - 1, xc] = 1;
            yc--;
        }
        yc = y;
        xc = x;

        while (CryPosition[yc, (xc + 7) % 8] == 0 && MrkCheck[yc, (xc + 7) % 8] == 0)
        {
            MrkCheck[yc, (xc + 7) % 8] = 1;
            xc = (xc + 7) % 8;
        }
        yc = y;
        xc = x;

        while (CryPosition[yc, (xc + 1) % 8] == 0 && MrkCheck[yc, (xc + 1) % 8] == 0)
        {
            MrkCheck[yc, (xc + 1) % 8] = 1;
            xc = (xc + 1) % 8;
        }

        yc = y;
        xc = x;

        while (yc < 7 && CryPosition[yc + 1, (xc + 7) % 8] == 0 && MrkCheck[yc + 1, (xc + 7) % 8] == 0)
        {
            MrkCheck[yc + 1, (xc + 7) % 8] = 1;
            yc++;
            xc = (xc + 7) % 8;
        }
        yc = y;
        xc = x;

        while (yc < 7 && CryPosition[yc + 1, (xc + 1) % 8] == 0 && MrkCheck[yc + 1, (xc + 1) % 8] == 0)
        {
            MrkCheck[yc + 1, (xc + 1) % 8] = 1;
            yc++;
            xc = (xc + 1) % 8;
        }
        yc = y;
        xc = x;

        while (yc > 0 && CryPosition[yc - 1, (xc + 1) % 8] == 0 && MrkCheck[yc - 1, (xc + 1) % 8] == 0)
        {
            MrkCheck[yc - 1, (xc + 1) % 8] = 1;
            yc--;
            xc = (xc + 1) % 8;
        }
        yc = y;
        xc = x;

        while (yc > 0 && CryPosition[yc - 1, (xc + 7) % 8] == 0 && MrkCheck[yc - 1, (xc + 7) % 8] == 0)
        {
            MrkCheck[yc - 1, (xc + 7) % 8] = 1;
            yc--;
            xc = (xc + 7) % 8;
        }

    }



    public void MrkBishop(int[,] CryPosition, int[,] MrkCheck, int x, int y)
    {
        int yc = y, xc = x;
        while (yc < 7 && CryPosition[yc + 1, (xc + 7) % 8] == 0 && MrkCheck[yc + 1, (xc + 7) % 8] == 0)
        {
            MrkCheck[yc + 1, (xc + 7) % 8] = 1;
            yc++;
            xc = (xc + 7) % 8;
        }
        yc = y;
        xc = x;

        while (yc < 7 && CryPosition[yc + 1, (xc + 1) % 8] == 0 && MrkCheck[yc + 1, (xc + 1) % 8] == 0)
        {
            MrkCheck[yc + 1, (xc + 1) % 8] = 1;
            yc++;
            xc = (xc + 1) % 8;
        }
        yc = y;
        xc = x;

        while (yc > 0 && CryPosition[yc - 1, (xc + 1) % 8] == 0 && MrkCheck[yc - 1, (xc + 1) % 8] == 0)
        {
            MrkCheck[yc - 1, (xc + 1) % 8] = 1;
            yc--;
            xc = (xc + 1) % 8;
        }
        yc = y;
        xc = x;

        while (yc > 0 && CryPosition[yc - 1, (xc + 7) % 8] == 0 && MrkCheck[yc - 1, (xc + 7) % 8] == 0)
        {
            MrkCheck[yc - 1, (xc + 7) % 8] = 1;
            yc--;
            xc = (xc + 7) % 8;
        }

    }



    public void MrkRook(int[,] CryPosition, int[,] MrkCheck, int x, int y)
    {
        int yc = y, xc = x;
        while (yc < 7 && CryPosition[yc + 1, xc] == 0 && MrkCheck[yc + 1, xc] == 0)
        {
            MrkCheck[yc + 1, xc] = 1;
            yc++;
        }
        yc = y;
        xc = x;

        while (yc > 0 && CryPosition[yc - 1, xc] == 0 && MrkCheck[yc - 1, xc] == 0)
        {
            MrkCheck[yc - 1, xc] = 1;
            yc--;
        }
        yc = y;
        xc = x;

        while (CryPosition[yc, (xc + 7) % 8] == 0 && MrkCheck[yc, (xc + 7) % 8] == 0)
        {
            MrkCheck[yc, (xc + 7) % 8] = 1;
            xc = (xc + 7) % 8;
        }
        yc = y;
        xc = x;

        while (CryPosition[yc, (xc + 1) % 8] == 0 && MrkCheck[yc, (xc + 1) % 8] == 0)
        {
            MrkCheck[yc, (xc + 1) % 8] = 1;
            xc = (xc + 1) % 8;
        }
    }

    public void MrkKing(int[,] CryPosition, int[,] MrkCheck, int x, int y)
    {
        if (y < 7 && CryPosition[y + 1, x] == 0)
        {
            MrkCheck[y + 1, x] = 1;
        }
        if (y < 7 && CryPosition[y + 1, (x + 1) % 8] == 0)
        {
            MrkCheck[y + 1, (x + 1) % 8] = 1;
        }
        if (y < 7 && CryPosition[y + 1, (x + 7) % 8] == 0)
        {
            MrkCheck[y + 1, (x + 7) % 8] = 1;
        }
        if (CryPosition[y, (x + 1) % 8] == 0)
        {
            MrkCheck[y, (x + 1) % 8] = 1;
        }
        if (CryPosition[y, (x + 7) % 8] == 0)
        {
            MrkCheck[y, (x + 7) % 8] = 1;
        }
        if (y > 0 && CryPosition[y - 1, x] == 0)
        {
            MrkCheck[y - 1, x] = 1;
        }
        if (y > 0 && CryPosition[y - 1, (x + 1) % 8] == 0)
        {
            MrkCheck[y - 1, (x + 1) % 8] = 1;
        }
        if (y > 0 && CryPosition[y - 1, (x + 7) % 8] == 0)
        {
            MrkCheck[y - 1, (x + 7) % 8] = 1;
        }
    }

    public void MrkKnight(int[,] CryPosition, int[,] MrkCheck, int x, int y)
    {
        if (y + 2 < 8 && CryPosition[y + 2, (x + 1) % 8] == 0)
        {
            MrkCheck[y + 2, (x + 1) % 8] = 1;
        }

        if (y + 2 < 8 && CryPosition[y + 2, (x + 7) % 8] == 0)
        {
            MrkCheck[y + 2, (x + 7) % 8] = 1;
        }

        if (y + 1 < 8 && CryPosition[y + 1, (x + 2) % 8] == 0)
        {
            MrkCheck[y + 1, (x + 2) % 8] = 1;
        }

        if (y + 1 < 8 && CryPosition[y + 1, (x + 6) % 8] == 0)
        {
            MrkCheck[y + 1, (x + 6) % 8] = 1;
        }

        if (y > 1 && CryPosition[y - 2, (x + 1) % 8] == 0)
        {
            MrkCheck[y - 2, (x + 1) % 8] = 1;
        }

        if (y > 1 && CryPosition[y - 2, (x + 7) % 8] == 0)
        {
            MrkCheck[y - 2, (x + 7) % 8] = 1;
        }

        if (y > 0 && CryPosition[y - 1, (x + 2) % 8] == 0)
        {
            MrkCheck[y - 1, (x + 2) % 8] = 1;
        }

        if (y > 0 && CryPosition[y - 1, (x + 6) % 8] == 0)
        {
            MrkCheck[y - 1, (x + 6) % 8] = 1;
        }


    }
}