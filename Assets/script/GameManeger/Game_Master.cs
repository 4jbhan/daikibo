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
                Rigidbody rigid = tmpobj.GetComponent<Rigidbody>();
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
    }
}