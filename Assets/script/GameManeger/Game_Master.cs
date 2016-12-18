using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Game_Master : MonoBehaviour
{
    public Field_Initializer f_init;
    public Data_Initializer d_init;
    public User_Interface u_i;
    public raw_position r_pos;
    public Object_Mover o_mov;
    public crystat[] cry_stat = new crystat[33];
    public int[,] CryPosition = new int[8, 8];
    public GameObject tmp = null, obj = null;
    bool f = true;
    int id;

    // Use this for initialization
    void Start()
    {
        f_init = GetComponent<Field_Initializer>();
        d_init = GetComponent<Data_Initializer>();
        u_i = GetComponent<User_Interface>();
        r_pos = GetComponent<raw_position>();
        o_mov = GetComponent<Object_Mover>();
        d_init.StatSetter(cry_stat);
        r_pos.setter();
        f_init.PosInit(CryPosition);
    }

    void Update()
    {
        /*      if (f==0 && u_i.getClickObject() != null)
                      {
                          GameObject Objective = u_i.getClickObject();
                          if (Objective.GetComponent<Rigidbody>() != null)
                          {
                              Rigidbody rigid = Objective.GetComponent<Rigidbody>();
                              rigid.GetComponent<Rigidbody>().MovePosition(r_pos.rawPosition[4, 4]);
                          }
                      }*/

        obj = u_i.getClickObject();
        if (obj != null)
        {

            if (f && obj != null && obj.name.IndexOf("Capsule") < 0 && obj.name != "planet" && obj.name.IndexOf("object") < 0)
            {

                u_i.MrkGenerator(cry_stat[d_init.NametoId[obj.name]], CryPosition);
                tmp = obj;
                f = false;

           //     StartCoroutine("sleep");
            }
            else if (!f && obj.name.IndexOf("Capsule") >= 0)
            {
                o_mov.MrkRemover();
                id = d_init.NametoId[tmp.name];
                Rigidbody rigid = tmp.GetComponent<Rigidbody>();
                rigid.GetComponent<Rigidbody>().MovePosition(r_pos.rawPosition[int.Parse(obj.name.Substring(0, 1)), int.Parse(obj.name.Substring(1, 1))]);
                CryPosition[cry_stat[id].y, cry_stat[id].x] = 0;
                cry_stat[id].y = int.Parse(obj.name.Substring(0, 1));
                cry_stat[id].x = int.Parse(obj.name.Substring(1, 1));
                CryPosition[cry_stat[id].y, cry_stat[id].x] = id;
                f = true;


             //   StartCoroutine("sleep");

            }
            else if (!f && obj.name.IndexOf("Capsule") < 0)
            {
                o_mov.MrkRemover();
                f = true;
            }
        }
    }

    IEnumerator sleep()
    {

        Debug.Log("開始");
        yield return new WaitForSeconds(5);  //10秒待つ
        Debug.Log("5秒経ちました");

    }
}


