using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingInfo : MonoBehaviour
{
    public Vector3 delta,rot_offset;
    public float cutout;
    Vector3 prev_pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        delta = Vector3.zero;
    }
    // Update is called once per frame
    void Update()
    {
        var temp = transform.position - prev_pos;
        if (temp.x > cutout || temp.x < -cutout) {  } else { temp.x = 0; }
        if (temp.y > cutout || temp.y < -cutout) {  } else { temp.y = 0; }
        if (temp.z > cutout || temp.z < -cutout) { } else { temp.z = 0; }
        delta = temp;
        prev_pos = transform.position;

    }
}
