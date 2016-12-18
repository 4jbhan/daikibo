using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public struct crystat
{
    public int hp;
    public int atk;
    public int x;
    public int y;
    public string personal;
    public int owntag;
    public bool iff;

    public void setter(int hitpoint, int atack, int iy, int ix, string name, int tag, bool who)
    {
        hp = hitpoint;
        atk = atack;
        x = ix;
        y = iy;
        personal = name;
        owntag = tag;
        iff = who;
    }
}

public class Data_Initializer : MonoBehaviour {
    public Dictionary<string, int> NametoId = new Dictionary<string, int>();
    
    // Use this for initialization
    void Start () {
    }
	
    public void PosSetter(int[,] CryPosition)
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

    public void StatSetter(crystat[] cry_stat)
    {
        //    cry_stat = new Crystal_Status[33];
        cry_stat[0].setter(0, 0, 0, 0, "null", 100, false);
        cry_stat[1].setter(5, 5, 0, 0, "myking",0,true);
        cry_stat[2].setter(4, 2, 0, 4, "myqueen",1, true);
        cry_stat[3].setter(2, 2, 0, 3, "mybishop1",2, true);
        cry_stat[4].setter(2, 2, 0, 7, "mybishop2",2, true);
        cry_stat[5].setter(2, 2, 0, 1, "myknight1",3, true);
        cry_stat[6].setter(2, 2, 0, 5, "myknight2",3, true);
        cry_stat[7].setter(3, 3, 0, 2, "myrook1", 4, true);
        cry_stat[8].setter(3, 3, 0, 6, "myrook2", 4, true);
        cry_stat[9].setter(1, 1, 1, 0, "mypawn1", 5, true);
        cry_stat[10].setter(1, 1, 1, 1, "mypawn2", 5, true);
        cry_stat[11].setter(1, 1, 1, 2, "mypawn3", 5, true);
        cry_stat[12].setter(1, 1, 1, 3, "mypawn4", 5, true);
        cry_stat[13].setter(1, 1, 1, 4, "mypawn5", 5, true);
        cry_stat[14].setter(1, 1, 1, 5, "mypawn6", 5, true);
        cry_stat[15].setter(1, 1, 1, 6, "mypawn7", 5, true);
        cry_stat[16].setter(1, 1, 1, 7, "mypawn8", 5, true);
        cry_stat[17].setter(5, 5, 1, 0, "enemyking", 0, false);
        cry_stat[18].setter(4, 2, 1, 4, "enemyqueen", 1, false);
        cry_stat[19].setter(2, 2, 7, 3, "enemybishop1", 2, false);
        cry_stat[20].setter(2, 2, 7, 7, "enemybishop2", 2, false);
        cry_stat[21].setter(2, 2, 7, 1, "enemyknight1", 3, false);
        cry_stat[22].setter(2, 2, 7, 5, "enemyknight2", 3, false);
        cry_stat[23].setter(3, 3, 7, 2, "enemyrook1", 4, false);
        cry_stat[24].setter(3, 3, 7, 6, "enemyrook2", 4, false);
        cry_stat[25].setter(1, 1, 6, 0, "enemypawn1", 5, false);
        cry_stat[26].setter(1, 1, 6, 1, "enemypawn2", 5, false);
        cry_stat[27].setter(1, 1, 6, 2, "enemypawn3", 5, false);
        cry_stat[28].setter(1, 1, 6, 3, "enemypawn4", 5, false);
        cry_stat[29].setter(1, 1, 6, 4, "enemypawn5", 5, false);
        cry_stat[30].setter(1, 1, 6, 5, "enemypawn6", 5, false);
        cry_stat[31].setter(1, 1, 6, 6, "enemypawn7", 5, false);
        cry_stat[32].setter(1, 1, 6, 7, "enemypawn8", 5, false);

    }

    public void DicSetter()
    {
        NametoId.Add("myking",1);
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
}