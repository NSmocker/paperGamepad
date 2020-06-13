using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class RightGamePadInput : MonoBehaviour
{
    public static bool cross, quad, tri;
    public static Transform RightHandTransform;
    public bool cr, qd, tr;



  

    // Start is called before the first frame update




    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        RightHandTransform = transform;
        cr = cross;
        qd = quad;
        tr = tri;
    }
}
