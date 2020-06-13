using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooter : MonoBehaviour
{

    public float shoot_timer, shoot_cd=0.2f;
    public float beem_timer;
    // Start is called before the first frame update
    public LineRenderer lr;
    public AudioSource gunSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        shoot_timer -= Time.deltaTime;
        beem_timer -= Time.deltaTime;
        RaycastHit hit;
        if (beem_timer>0){ lr.enabled = true; }
        else lr.enabled = false;


        if (Input.GetButton("Fire1") && shoot_timer<=0)
        {
            shoot_timer = shoot_cd;
            gunSound.PlayOneShot(gunSound.clip);
            beem_timer = 0.3f;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                Debug.Log("Did Hit");
                
                if (hit.collider.tag == "Sundew")
                {
                    var stats = hit.collider.gameObject.GetComponent<Stats>();
                    stats.hp -= 30;
                    stats.InstantDamage();

                }

            }
        }
        

    }
}
