using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public struct Crystal_Status
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

public class Data_Initializer : MonoBehaviour
{
    public Dictionary<string, int> NametoId = new Dictionary<string, int>();
    public Vector3[,] rawPosition = new Vector3[8, 8];

    // Use this for initialization
    void Start()
    {
    }

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

    public void StatSetter(Crystal_Status[] crystat)
    {
        //    cry_stat = new Crystal_Status[33];
        crystat[0].setter(0, 0, 0, 0, "myobject", 100, false);
        crystat[1].setter(5, 5, 0, 0, "myking", 0, true);
        crystat[2].setter(4, 2, 0, 4, "myqueen", 1, true);
        crystat[3].setter(2, 2, 0, 3, "mybishop1", 2, true);
        crystat[4].setter(2, 2, 0, 7, "mybishop2", 2, true);
        crystat[5].setter(2, 2, 0, 1, "myknight1", 3, true);
        crystat[6].setter(2, 2, 0, 5, "myknight2", 3, true);
        crystat[7].setter(3, 3, 0, 2, "myrook1", 4, true);
        crystat[8].setter(3, 3, 0, 6, "myrook2", 4, true);
        crystat[9].setter(1, 1, 1, 0, "mypawn1", 5, true);
        crystat[10].setter(1, 1, 1, 1, "mypawn2", 5, true);
        crystat[11].setter(1, 1, 1, 2, "mypawn3", 5, true);
        crystat[12].setter(1, 1, 1, 3, "mypawn4", 5, true);
        crystat[13].setter(1, 1, 1, 4, "mypawn5", 5, true);
        crystat[14].setter(1, 1, 1, 5, "mypawn6", 5, true);
        crystat[15].setter(1, 1, 1, 6, "mypawn7", 5, true);
        crystat[16].setter(1, 1, 1, 7, "mypawn8", 5, true);
        crystat[17].setter(5, 5, 1, 0, "enemyking", 0, false);
        crystat[18].setter(4, 2, 1, 4, "enemyqueen", 1, false);
        crystat[19].setter(2, 2, 7, 3, "enemybishop1", 2, false);
        crystat[20].setter(2, 2, 7, 7, "enemybishop2", 2, false);
        crystat[21].setter(2, 2, 7, 1, "enemyknight1", 3, false);
        crystat[22].setter(2, 2, 7, 5, "enemyknight2", 3, false);
        crystat[23].setter(3, 3, 7, 2, "enemyrook1", 4, false);
        crystat[24].setter(3, 3, 7, 6, "enemyrook2", 4, false);
        crystat[25].setter(1, 1, 6, 0, "enemypawn1", 5, false);
        crystat[26].setter(1, 1, 6, 1, "enemypawn2", 5, false);
        crystat[27].setter(1, 1, 6, 2, "enemypawn3", 5, false);
        crystat[28].setter(1, 1, 6, 3, "enemypawn4", 5, false);
        crystat[29].setter(1, 1, 6, 4, "enemypawn5", 5, false);
        crystat[30].setter(1, 1, 6, 5, "enemypawn6", 5, false);
        crystat[31].setter(1, 1, 6, 6, "enemypawn7", 5, false);
        crystat[32].setter(1, 1, 6, 7, "enemypawn8", 5, false);
    }

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

    public void attacking(Crystal_Status attacker, Crystal_Status defender)
    {
        defender.hp -= attacker.atk;
    }
}