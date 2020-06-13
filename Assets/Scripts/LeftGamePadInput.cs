using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class LeftGamePadInput : MonoBehaviour
{
    public static bool jump;
    public static Transform LeftHandTransform;
    public bool jmp;
    public VirtualButtonBehaviour[] buttons;



    // Start is called before the first frame update




    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        LeftHandTransform = transform;
        jmp = jump;
        
    }
}

