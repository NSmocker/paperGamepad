using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed,gyro_sens;
    public GameObject cam;

    public Rigidbody rb;
    public Vector2 motion_input, camera_input;

    float jump_timer, jump_cd=2f ;
   
    Gyroscope gyro;
    public bool gyroEnabled;
    public bool defaultHeadTracking;
    public Vector3 gyroTrehshold;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gyroEnabled = EnableGyro();


    }
    bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled=true;
            return true;
        }
        return false;

    }
    void Motion()
    {
    
        var moving_vector = new Vector3(motion_input.x * speed, rb.velocity.y, motion_input.y * speed);
        rb.velocity = transform.TransformDirection(moving_vector);

        if (Input.GetButton("Jump"))
        {
            if (jump_timer <= 0)
            {

                jump_timer = jump_cd;
                var temp_vel = rb.velocity;
                temp_vel.y = 4f;
                rb.velocity = temp_vel;
            }
        }

  if (defaultHeadTracking)
        {

            if (gyroEnabled)
            {
                var filter = gyro.rotationRateUnbiased;

                if (filter.y > gyroTrehshold.y || filter.y < -gyroTrehshold.y) { filter.y *= gyro_sens; } else { filter.y = 0; }
                if (filter.x > gyroTrehshold.x || filter.x < -gyroTrehshold.x) { } else { filter.x = 0; }
                if (filter.z > gyroTrehshold.z || filter.z < -gyroTrehshold.z) { } else { filter.z = 0; }

                var temp_for_cam = filter;
                temp_for_cam.y = 0;
                var temp_for_player = filter;
                temp_for_player.x = 0;


                cam.transform.eulerAngles -= temp_for_cam;
                transform.eulerAngles -= temp_for_player;
            }
        }
       


    }
    
    // Update is called once per frame
    void Update()
    {
        jump_timer -= Time.deltaTime;
        motion_input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (motion_input == Vector2.zero) {if(LeftGamePadInput.jump==true) motion_input = new Vector2(0, 1); }

        Motion();

       




    }
}
