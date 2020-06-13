using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempCamBackground : MonoBehaviour
{
    public float timer=1f;
    public GameObject checkin_plane;
    public  Shader img_shader;

    public GameObject b_plane;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        var mesh = GetComponent<MeshRenderer>();
        mesh.enabled = Input.GetButton("Center");
        
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (b_plane == null)
            {
                b_plane = GameObject.Find("BackgroundPlane");
                checkin_plane.GetComponent<MeshRenderer>().material = b_plane.GetComponent<MeshRenderer>().material;
                checkin_plane.GetComponent<MeshRenderer>().material.shader = img_shader;
            }
        }
    }
  

}
