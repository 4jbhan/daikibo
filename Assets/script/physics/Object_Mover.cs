using UnityEngine;
using System.Collections;

public class Object_Mover : MonoBehaviour
{
    //マーカーに使用するオブジェクト
    public GameObject marker;

    //他スクリプトのインスタンス
    Game_Data g_data;

    void Start()
    {
        g_data = GetComponent<Game_Data>();
        g_data.RawPossetter();
    }

    //盤面の状態から実際に駒の展開を一気に行う
    //主に盤面の初期化用
    public void ArraytoPos(int[,] CryPosition)
    {

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                string tmp = null;
                switch (CryPosition[i, j])//idに応じて移動させる駒の名前を設定
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
                    GameObject hand = GameObject.Find(tmp);//駒の名前からオブジェクトの実体を取得する
                    Rigidbody rigid = hand.GetComponent<Rigidbody>();
                    rigid.GetComponent<Rigidbody>().MovePosition(g_data.rawPosition[i, j]);

                }
            }
        }
    }
}