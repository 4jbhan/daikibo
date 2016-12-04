using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour
{

    //   const float grav_amou = 9.80665;
    public GameObject planet;       // 引力の発生する星
    public float accelerationScale; // 加速度の大きさ

    void FixedUpdate()
    {
        // 星に向かう向きの取得
        var direction = planet.transform.position - transform.position;
        direction.Normalize();

        GetComponent<Rigidbody>().AddForce(accelerationScale * direction, ForceMode.Acceleration);
    }
}
