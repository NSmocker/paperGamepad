using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public GameObject prefab_to_spawn;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            time = 1f;
            Destroy(Instantiate(prefab_to_spawn,transform.position,transform.rotation), 4f);
        }
    

        
    }
}
