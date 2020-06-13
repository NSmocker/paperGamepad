using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyPadMovement : MonoBehaviour
{
    public Transform Anchor;
    public  static float vertical, horizontal;
    public float vert, hor;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var filter = LeftGamePadInput.LeftHandTransform.eulerAngles;
        filter.x += 90f;
        filter.z = 0;
        vertical =  filter.x /100; 
        horizontal =  filter.y/ 100;
        vert = vertical;
        hor = horizontal;

        Anchor.eulerAngles = filter;


        

        // Y - нахили вліво вправо
        // X- Вперед назад
        
    }
}
