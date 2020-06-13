using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffinController : MonoBehaviour
{
    [Header("States")]

    public bool fall;
    public bool walk;
    public bool pressF;

    [Header("System Vars")]
    public Animator anim;
    public Rigidbody rb;
    public float walkSpeed;


    public void Walk()
    {
        var vel = rb.velocity;
        var dir = transform.TransformDirection(Vector3.forward * walkSpeed);
        dir.y = vel.y;
        rb.velocity = dir;

    }

    public void ApplyStates()
    {
      
        anim.SetBool("fall", fall);
        anim.SetBool("walk", walk);
        if(fall==false)anim.SetBool("pressF", pressF);

        if (walk) {   Walk();  }
        
    }



    public void Obstacle(GameObject obs)
    {
        Vector3 my_angle= transform.eulerAngles ;

        if (obs.tag == "turn_R") { Destroy(obs);my_angle.y += 90;  }
        if (obs.tag == "turn_L") { Destroy(obs); my_angle.y -= 90; }
        if (obs.tag == "stay") { Destroy(obs); GameManagerScript.stayTimer = 2f;}

    }

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        ApplyStates();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
