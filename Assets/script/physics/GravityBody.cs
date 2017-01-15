using UnityEngine;
using System.Collections;

public class GravityBody : MonoBehaviour
{
    public GravityAttractor attractor;
    private Transform myTransform;

    void Awake()
    {
        attractor = Object.FindObjectOfType<GravityAttractor>();
    }

    void Start()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody>().useGravity = false;
        myTransform = transform;
    }

    void Update()
    {
        if (attractor != null)
        {
            //GetComponent<Rigidbody>().isKinematic = false;
            attractor.Attract(myTransform);
            //GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
