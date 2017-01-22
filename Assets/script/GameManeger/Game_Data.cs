using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public struct Crystal_Status
{
    //各ステータス
    public int hp;
    public int atk;

    //初期座標
    public int x;
    public int y;
    
    //駒の名前
    public string name;

    //駒の種別
    //0 = キング　
    //1 = クイーン
    //2 = ビショップ
    //3 = ナイト
    //4 = ルーク
    //5 = ポーン
    public int tag;
    
    //青か赤か
    //true = 青　false = 赤
    public bool iff;

    //攻撃対象になりうる状態かどうか
    public bool targeted;

    //初期化用関数
    public void setter(int hitpoint, int atack, int iy, int ix, string myname, int mytag, bool who, bool target)
    {
        hp = hitpoint;
        atk = atack;
        x = ix;
        y = iy;
        name = myname;
        tag = mytag;
        iff = who;
        targeted = target;
    }
}

public class Game_Data : MonoBehaviour
{
    //名前からidへの変換用リファレンス
    //辞書型、詳しくは調べて
    public Dictionary<string, int> NametoId = new Dictionary<string, int>();

    //盤面上の座標の実体
    //unity上では座標はベクトルなのでそれに準拠
    public Vector3[,] rawPosition = new Vector3[8, 8];
 

    //CryPosition(盤面の状態)の初期化
    public void CryPosSetter(int[,] CryPosition)
    {
        CryPosition[0, 0] = 1;
        CryPosition[0, 1] = 5;
        CryPosition[0, 2] = 7;
        CryPosition[0, 3] = 3;
        CryPosition[0, 4] = 2;
        CryPosition[0, 5] = 6;
        CryPosition[0, 6] = 8;
        CryPosition[0, 7] = 4;
        CryPosition[1, 0] = 9;
        CryPosition[1, 1] = 10;
        CryPosition[1, 2] = 11;
        CryPosition[1, 3] = 12;
        CryPosition[1, 4] = 13;
        CryPosition[1, 5] = 14;
        CryPosition[1, 6] = 15;
        CryPosition[1, 7] = 16;
        CryPosition[2, 0] = 0;
        CryPosition[2, 1] = 0;
        CryPosition[2, 2] = 0;
        CryPosition[2, 3] = 0;
        CryPosition[2, 4] = 0;
        CryPosition[2, 5] = 0;
        CryPosition[2, 6] = 0;
        CryPosition[2, 7] = 0;
        CryPosition[3, 0] = 0;
        CryPosition[3, 1] = 0;
        CryPosition[3, 2] = 0;
        CryPosition[3, 3] = 0;
        CryPosition[3, 4] = 0;
        CryPosition[3, 5] = 0;
        CryPosition[3, 6] = 0;
        CryPosition[3, 7] = 0;
        CryPosition[4, 0] = 0;
        CryPosition[4, 1] = 0;
        CryPosition[4, 2] = 0;
        CryPosition[4, 3] = 0;
        CryPosition[4, 4] = 0;
        CryPosition[4, 5] = 0;
        CryPosition[4, 6] = 0;
        CryPosition[4, 7] = 0;
        CryPosition[5, 0] = 0;
        CryPosition[5, 1] = 0;
        CryPosition[5, 2] = 0;
        CryPosition[5, 3] = 0;
        CryPosition[5, 4] = 0;
        CryPosition[5, 5] = 0;
        CryPosition[5, 6] = 0;
        CryPosition[5, 7] = 0;
        CryPosition[6, 0] = 25;
        CryPosition[6, 1] = 26;
        CryPosition[6, 2] = 27;
        CryPosition[6, 3] = 28;
        CryPosition[6, 4] = 29;
        CryPosition[6, 5] = 30;
        CryPosition[6, 6] = 31;
        CryPosition[6, 7] = 32;
        CryPosition[7, 0] = 17;
        CryPosition[7, 1] = 21;
        CryPosition[7, 2] = 23;
        CryPosition[7, 3] = 19;
        CryPosition[7, 4] = 18;
        CryPosition[7, 5] = 22;
        CryPosition[7, 6] = 24;
        CryPosition[7, 7] = 20;
    }

    //各クリスタルのステータス設定
    //0番目に関しては仮でmyobjectと設定してあるけど使っていない
    public void StatSetter(Crystal_Status[] crystat)
    {
        crystat[0].setter(5, 0, 100, 100, "myobject", 100, false, false);
        crystat[1].setter(5, 5, 0, 0, "myking", 0, true, false);
        crystat[2].setter(4, 2, 0, 4, "myqueen", 1, true, false);
        crystat[3].setter(2, 2, 0, 3, "mybishop1", 2, true, false);
        crystat[4].setter(2, 2, 0, 7, "mybishop2", 2, true, false);
        crystat[5].setter(2, 2, 0, 1, "myknight1", 3, true, false);
        crystat[6].setter(2, 2, 0, 5, "myknight2", 3, true, false);
        crystat[7].setter(3, 3, 0, 2, "myrook1", 4, true, false);
        crystat[8].setter(3, 3, 0, 6, "myrook2", 4, true, false);
        crystat[9].setter(1, 1, 1, 0, "mypawn1", 5, true, false);
        crystat[10].setter(1, 1, 1, 1, "mypawn2", 5, true, false);
        crystat[11].setter(1, 1, 1, 2, "mypawn3", 5, true, false);
        crystat[12].setter(1, 1, 1, 3, "mypawn4", 5, true, false);
        crystat[13].setter(1, 1, 1, 4, "mypawn5", 5, true, false);
        crystat[14].setter(1, 1, 1, 5, "mypawn6", 5, true, false);
        crystat[15].setter(1, 1, 1, 6, "mypawn7", 5, true, false);
        crystat[16].setter(1, 1, 1, 7, "mypawn8", 5, true, false);
        crystat[17].setter(5, 5, 7, 0, "enemyking", 0, false, false);
        crystat[18].setter(4, 2, 7, 4, "enemyqueen", 1, false, false);
        crystat[19].setter(2, 2, 7, 3, "enemybishop1", 2, false, false);
        crystat[20].setter(2, 2, 7, 7, "enemybishop2", 2, false, false);
        crystat[21].setter(2, 2, 7, 1, "enemyknight1", 3, false, false);
        crystat[22].setter(2, 2, 7, 5, "enemyknight2", 3, false, false);
        crystat[23].setter(3, 3, 7, 2, "enemyrook1", 4, false, false);
        crystat[24].setter(3, 3, 7, 6, "enemyrook2", 4, false, false);
        crystat[25].setter(1, 1, 6, 0, "enemypawn1", 5, false, false);
        crystat[26].setter(1, 1, 6, 1, "enemypawn2", 5, false, false);
        crystat[27].setter(1, 1, 6, 2, "enemypawn3", 5, false, false);
        crystat[28].setter(1, 1, 6, 3, "enemypawn4", 5, false, false);
        crystat[29].setter(1, 1, 6, 4, "enemypawn5", 5, false, false);
        crystat[30].setter(1, 1, 6, 5, "enemypawn6", 5, false, false);
        crystat[31].setter(1, 1, 6, 6, "enemypawn7", 5, false, false);
        crystat[32].setter(1, 1, 6, 7, "enemypawn8", 5, false, false);
        crystat[33].setter(5, 0, 100, 100, "enemyobject", 100, false, false);
    }

    //idと各駒の対応表
    public void DicSetter()
    {
        NametoId.Add("myking", 1);
        NametoId.Add("myqueen", 2);
        NametoId.Add("mybishop1", 3);
        NametoId.Add("mybishop2", 4);
        NametoId.Add("myknight1", 5);
        NametoId.Add("myknight2", 6);
        NametoId.Add("myrook1", 7);
        NametoId.Add("myrook2", 8);
        NametoId.Add("mypawn1", 9);
        NametoId.Add("mypawn2", 10);
        NametoId.Add("mypawn3", 11);
        NametoId.Add("mypawn4", 12);
        NametoId.Add("mypawn5", 13);
        NametoId.Add("mypawn6", 14);
        NametoId.Add("mypawn7", 15);
        NametoId.Add("mypawn8", 16);
        NametoId.Add("enemyking", 17);
        NametoId.Add("enemyqueen", 18);
        NametoId.Add("enemybishop1", 19);
        NametoId.Add("enemybishop2", 20);
        NametoId.Add("enemyknight1", 21);
        NametoId.Add("enemyknight2", 22);
        NametoId.Add("enemyrook1", 23);
        NametoId.Add("enemyrook2", 24);
        NametoId.Add("enemypawn1", 25);
        NametoId.Add("enemypawn2", 26);
        NametoId.Add("enemypawn3", 27);
        NametoId.Add("enemypawn4", 28);
        NametoId.Add("enemypawn5", 29);
        NametoId.Add("enemypawn6", 30);
        NametoId.Add("enemypawn7", 31);
        NametoId.Add("enemypawn8", 32);
    }

    //盤面上の実体座標
    //アクセスは　rawPosition[y,x]
    public void RawPossetter()
    {
        rawPosition[0, 0] = new Vector3((float)3.159854, (float)-9.396926, (float)1.308854);
        rawPosition[0, 1] = new Vector3((float)1.308854, (float)-9.396926, (float)3.159854);
        rawPosition[0, 2] = new Vector3((float)-1.308854, (float)-9.396926, (float)3.159854);
        rawPosition[0, 3] = new Vector3((float)-3.159854, (float)-9.396926, (float)1.308854);
        rawPosition[0, 4] = new Vector3((float)-3.159854, (float)-9.396926, (float)-1.308854);
        rawPosition[0, 5] = new Vector3((float)-1.308854, (float)-9.396926, (float)-3.159854);
        rawPosition[0, 6] = new Vector3((float)1.308854, (float)-9.396926, (float)-3.159854);
        rawPosition[0, 7] = new Vector3((float)3.159854, (float)-9.396926, (float)-1.308854);
        rawPosition[1, 0] = new Vector3((float)5.938583, (float)-7.660444, (float)2.459842);
        rawPosition[1, 1] = new Vector3((float)2.459842, (float)-7.660444, (float)5.938583);
        rawPosition[1, 2] = new Vector3((float)-2.459842, (float)-7.660444, (float)5.938583);
        rawPosition[1, 3] = new Vector3((float)-5.938583, (float)-7.660444, (float)2.459842);
        rawPosition[1, 4] = new Vector3((float)-5.938583, (float)-7.660444, (float)-2.459842);
        rawPosition[1, 5] = new Vector3((float)-2.459842, (float)-7.660444, (float)-5.938583);
        rawPosition[1, 6] = new Vector3((float)2.459842, (float)-7.660444, (float)-5.938583);
        rawPosition[1, 7] = new Vector3((float)5.938583, (float)-7.660444, (float)-2.459842);
        rawPosition[2, 0] = new Vector3((float)8.001031, (float)-5.000000, (float)3.314136);
        rawPosition[2, 1] = new Vector3((float)3.314136, (float)-5.000000, (float)8.001031);
        rawPosition[2, 2] = new Vector3((float)-3.314136, (float)-5.000000, (float)8.001031);
        rawPosition[2, 3] = new Vector3((float)-8.001031, (float)-5.000000, (float)3.314136);
        rawPosition[2, 4] = new Vector3((float)-8.001031, (float)-5.000000, (float)-3.314136);
        rawPosition[2, 5] = new Vector3((float)-3.314136, (float)-5.000000, (float)-8.001031);
        rawPosition[2, 6] = new Vector3((float)3.314136, (float)-5.000000, (float)-8.001031);
        rawPosition[2, 7] = new Vector3((float)8.001031, (float)-5.000000, (float)-3.314136);
        rawPosition[3, 0] = new Vector3((float)9.098437, (float)-1.736482, (float)3.768696);
        rawPosition[3, 1] = new Vector3((float)3.768696, (float)-1.736482, (float)9.098437);
        rawPosition[3, 2] = new Vector3((float)-3.768696, (float)-1.736482, (float)9.098437);
        rawPosition[3, 3] = new Vector3((float)-9.098437, (float)-1.736482, (float)3.768696);
        rawPosition[3, 4] = new Vector3((float)-9.098437, (float)-1.736482, (float)-3.768696);
        rawPosition[3, 5] = new Vector3((float)-3.768696, (float)-1.736482, (float)-9.098437);
        rawPosition[3, 6] = new Vector3((float)3.768696, (float)-1.736482, (float)-9.098437);
        rawPosition[3, 7] = new Vector3((float)9.098437, (float)-1.736482, (float)-3.768696);
        rawPosition[4, 0] = new Vector3((float)9.098437, (float)1.736482, (float)3.768696);
        rawPosition[4, 1] = new Vector3((float)3.768696, (float)1.736482, (float)9.098437);
        rawPosition[4, 2] = new Vector3((float)-3.768696, (float)1.736482, (float)9.098437);
        rawPosition[4, 3] = new Vector3((float)-9.098437, (float)1.736482, (float)3.768696);
        rawPosition[4, 4] = new Vector3((float)-9.098437, (float)1.736482, (float)-3.768696);
        rawPosition[4, 5] = new Vector3((float)-3.768696, (float)1.736482, (float)-9.098437);
        rawPosition[4, 6] = new Vector3((float)3.768696, (float)1.736482, (float)-9.098437);
        rawPosition[4, 7] = new Vector3((float)9.098437, (float)1.736482, (float)-3.768696);
        rawPosition[5, 0] = new Vector3((float)8.001031, (float)5.000000, (float)3.314136);
        rawPosition[5, 1] = new Vector3((float)3.314136, (float)5.000000, (float)8.001031);
        rawPosition[5, 2] = new Vector3((float)-3.314136, (float)5.000000, (float)8.001031);
        rawPosition[5, 3] = new Vector3((float)-8.001031, (float)5.000000, (float)3.314136);
        rawPosition[5, 4] = new Vector3((float)-8.001031, (float)5.000000, (float)-3.314136);
        rawPosition[5, 5] = new Vector3((float)-3.314136, (float)5.000000, (float)-8.001031);
        rawPosition[5, 6] = new Vector3((float)3.314136, (float)5.000000, (float)-8.001031);
        rawPosition[5, 7] = new Vector3((float)8.001031, (float)5.000000, (float)-3.314136);
        rawPosition[6, 0] = new Vector3((float)5.938583, (float)7.660444, (float)2.459842);
        rawPosition[6, 1] = new Vector3((float)2.459842, (float)7.660444, (float)5.938583);
        rawPosition[6, 2] = new Vector3((float)-2.459842, (float)7.660444, (float)5.938583);
        rawPosition[6, 3] = new Vector3((float)-5.938583, (float)7.660444, (float)2.459842);
        rawPosition[6, 4] = new Vector3((float)-5.938583, (float)7.660444, (float)-2.459842);
        rawPosition[6, 5] = new Vector3((float)-2.459842, (float)7.660444, (float)-5.938583);
        rawPosition[6, 6] = new Vector3((float)2.459842, (float)7.660444, (float)-5.938583);
        rawPosition[6, 7] = new Vector3((float)5.938583, (float)7.660444, (float)-2.459842);
        rawPosition[7, 0] = new Vector3((float)3.159854, (float)9.396926, (float)1.308854);
        rawPosition[7, 1] = new Vector3((float)1.308854, (float)9.396926, (float)3.159854);
        rawPosition[7, 2] = new Vector3((float)-1.308854, (float)9.396926, (float)3.159854);
        rawPosition[7, 3] = new Vector3((float)-3.159854, (float)9.396926, (float)1.308854);
        rawPosition[7, 4] = new Vector3((float)-3.159854, (float)9.396926, (float)-1.308854);
        rawPosition[7, 5] = new Vector3((float)-1.308854, (float)9.396926, (float)-3.159854);
        rawPosition[7, 6] = new Vector3((float)1.308854, (float)9.396926, (float)-3.159854);
        rawPosition[7, 7] = new Vector3((float)3.159854, (float)9.396926, (float)-1.308854);
    }
}