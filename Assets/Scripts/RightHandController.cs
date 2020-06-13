using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class RightHandController : MonoBehaviour
{
    public Animator anim;
    public bool click, grab;
    

  
  
   
   

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
      
        anim.SetBool("Click", click);
        anim.SetBool("Grab", grab);
    }
}
