using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SundewMover : MonoBehaviour
{
    public Stats stats;
    public Rigidbody rb;
    public float moove_speed;

    // Start is called before the first frame update

    void Start()
    {
        stats = GetComponent<Stats>();

    }

    // Update is called once per frame
    void Update()
    {
        if (stats.hp > 0)
        {
            transform.LookAt(GameObject.Find("Player").transform.position);
            Vector3 temp_vel = rb.velocity;
            temp_vel = transform.TransformDirection(Vector3.forward * moove_speed );
            temp_vel.y = rb.velocity.y;
            rb.velocity = temp_vel;
        }

    }
}
