using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Game_Master : MonoBehaviour
{

    public Data_Initializer d_init;
    public User_Interface u_i;
  //  public raw_position r_pos;
    public Object_Mover o_mov;

    public GameObject tmpobj = null, obj = null;
    public Crystal_Status[] crystat = new Crystal_Status[33];
    public int[,] CryPosition = new int[8, 8];
    
    public bool marked = false, moved = false;
    int id;

    //Use these for Hp,atk text
    public TextMesh Text_HpAtk1;
    public TextMesh Text_HpAtk2;
    public TextMesh Text_HpAtk3;
    public TextMesh Text_HpAtk4;
    public TextMesh Text_HpAtk5;
    public TextMesh Text_HpAtk6;
    public TextMesh Text_HpAtk7;
    public TextMesh Text_HpAtk8;
    public TextMesh Text_HpAtk9;
    public TextMesh Text_HpAtk10;
    public TextMesh Text_HpAtk11;
    public TextMesh Text_HpAtk12;
    public TextMesh Text_HpAtk13;
    public TextMesh Text_HpAtk14;
    public TextMesh Text_HpAtk15;
    public TextMesh Text_HpAtk16;
    public TextMesh Text_HpAtk17;
    public TextMesh Text_HpAtk18;
    public TextMesh Text_HpAtk19;
    public TextMesh Text_HpAtk20;
    public TextMesh Text_HpAtk21;
    public TextMesh Text_HpAtk22;
    public TextMesh Text_HpAtk23;
    public TextMesh Text_HpAtk24;
    public TextMesh Text_HpAtk25;
    public TextMesh Text_HpAtk26;
    public TextMesh Text_HpAtk27;
    public TextMesh Text_HpAtk28;
    public TextMesh Text_HpAtk29;
    public TextMesh Text_HpAtk30;
    public TextMesh Text_HpAtk31;
    public TextMesh Text_HpAtk32;

    // Use this for initialization
    void Start()
    {

        d_init = GetComponent<Data_Initializer>();
        u_i = GetComponent<User_Interface>();
      //  r_pos = GetComponent<raw_position>();
        o_mov = GetComponent<Object_Mover>();


        d_init.StatSetter(crystat);
      //  r_pos.setter();

        d_init.CryPosSetter(CryPosition);
        d_init.RawPossetter();
        d_init.DicSetter();
        o_mov.ArraytoPos(CryPosition);

    }

    void Update()
    {
        obj = u_i.getClickObject();
        if (obj != null)
        {

            if (!moved && !marked && obj != null && obj.name.IndexOf("Marker") < 0 && obj.name != "planet" && obj.name.IndexOf("object") < 0)
            {//マーカー展開
                id = d_init.NametoId[obj.name];
                if (crystat[id].iff == true)
                {
                    u_i.MrkGenerator(crystat[id], CryPosition);
                    tmpobj = obj;
                    marked = true;
                }
            }
            else if (!moved && marked && obj.name.IndexOf("Marker") >= 0)
            {//マーカークリック　移動
                o_mov.MrkRemover();
                id = d_init.NametoId[tmpobj.name];
                var rigid = tmpobj.GetComponent<Rigidbody>();
                rigid.GetComponent<Rigidbody>().MovePosition(d_init.rawPosition[int.Parse(obj.name.Substring(0, 1)), int.Parse(obj.name.Substring(1, 1))]);
                CryPosition[crystat[id].y, crystat[id].x] = 0;
                crystat[id].y = int.Parse(obj.name.Substring(0, 1));
                crystat[id].x = int.Parse(obj.name.Substring(1, 1));
                CryPosition[crystat[id].y, crystat[id].x] = id;
                marked = false;
                moved = true;
                if (!u_i.canAtkCheck(crystat[id],CryPosition)) {
                    moved = false;
                }
            }
            else if (!moved && marked && obj.name.IndexOf("Marker") < 0 && tmpobj.name != obj.name)
            {//マーカーキャンセル
                o_mov.MrkRemover();
                marked = false;
            }
            else if(!moved && marked && tmpobj.name == obj.name)
            {//移動放棄
                o_mov.MrkRemover();

                marked = false;
                moved = true;
                if (!u_i.canAtkCheck(crystat[id], CryPosition))
                {
                    moved = false;
                }
            }
            else if (moved && obj.name.IndexOf("Marker") < 0 && obj.name != "planet")
            {
                id  = d_init.NametoId[tmpobj.name];
                int did = d_init.NametoId[obj.name];
                if (!crystat[did].iff && u_i.AtkCheck(crystat[id], crystat[did]))
                {
                    
                    crystat[did].hp -= crystat[id].atk;
                    moved = false;
                    if (crystat[did].hp <= 0)
                    {
                        CryPosition[crystat[did].y, crystat[did].x] = 0;
                        GameObject hand = GameObject.Find(crystat[did].personal);
                        Destroy(hand);
                    }                                        
                }
            }
        }
        //Display Hp,Atk text
        Text_HpAtk1.text = "King\nH" + crystat[1].hp + ":A" + crystat[1].atk;
        Text_HpAtk2.text = "Queen\nH" + crystat[2].hp + ":A" + crystat[2].atk;
        Text_HpAtk3.text = "Bishop\nH" + crystat[3].hp + ":A" + crystat[3].atk;
        Text_HpAtk4.text = "Bishop\nH" + crystat[4].hp + ":A" + crystat[4].atk;
        Text_HpAtk5.text = "knight\nH" + crystat[5].hp + ":A" + crystat[5].atk;
        Text_HpAtk6.text = "knight\nH" + crystat[6].hp + ":A" + crystat[6].atk;
        Text_HpAtk7.text = "Rook\nH" + crystat[7].hp + ":A" + crystat[7].atk;
        Text_HpAtk8.text = "Rook\nH" + crystat[8].hp + ":A" + crystat[8].atk;
        Text_HpAtk9.text = "Pawn\nH" + crystat[9].hp + ":A" + crystat[9].atk;
        Text_HpAtk10.text = "Pawn\nH" + crystat[10].hp + ":A" + crystat[10].atk;
        Text_HpAtk11.text = "Pawn\nH" + crystat[11].hp + ":A" + crystat[11].atk;
        Text_HpAtk12.text = "Pawn\nH" + crystat[12].hp + ":A" + crystat[12].atk;
        Text_HpAtk13.text = "Pawn\nH" + crystat[13].hp + ":A" + crystat[13].atk;
        Text_HpAtk14.text = "Pawn\nH" + crystat[14].hp + ":A" + crystat[14].atk;
        Text_HpAtk15.text = "Pawn\nH" + crystat[15].hp + ":A" + crystat[15].atk;
        Text_HpAtk16.text = "Pawn\nH" + crystat[16].hp + ":A" + crystat[16].atk;
        Text_HpAtk17.text = "king\nH" + crystat[17].hp + ":A" + crystat[17].atk;
        Text_HpAtk18.text = "Queen\nH" + crystat[18].hp + ":A" + crystat[18].atk;
        Text_HpAtk19.text = "Bishop\nH" + crystat[19].hp + ":A" + crystat[19].atk;
        Text_HpAtk20.text = "bishop\nH" + crystat[20].hp + ":A" + crystat[20].atk;
        Text_HpAtk21.text = "knight\nH" + crystat[21].hp + ":A" + crystat[21].atk;
        Text_HpAtk22.text = "knight\nH" + crystat[22].hp + ":A" + crystat[22].atk;
        Text_HpAtk23.text = "Rook\nH" + crystat[23].hp + ":A" + crystat[23].atk;
        Text_HpAtk24.text = "Rook\nH" + crystat[24].hp + ":A" + crystat[24].atk;
        Text_HpAtk25.text = "Pawn\nH" + crystat[25].hp + ":A" + crystat[25].atk;
        Text_HpAtk26.text = "Pawn\nH" + crystat[26].hp + ":A" + crystat[26].atk;
        Text_HpAtk27.text = "Pawn\nH" + crystat[27].hp + ":A" + crystat[27].atk;
        Text_HpAtk28.text = "Pawn\nH" + crystat[28].hp + ":A" + crystat[28].atk;
        Text_HpAtk29.text = "Pawn\nH" + crystat[29].hp + ":A" + crystat[29].atk;
        Text_HpAtk30.text = "Pawn\nH" + crystat[30].hp + ":A" + crystat[30].atk;
        Text_HpAtk31.text = "Pawn\nH" + crystat[31].hp + ":A" + crystat[31].atk;
        Text_HpAtk32.text = "Pawn\nH" + crystat[32].hp + ":A" + crystat[32].atk;

    }
}