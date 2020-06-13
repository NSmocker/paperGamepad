using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SundewSpawner : MonoBehaviour
{
    public float resp_timer, resp_cd;
    public GameObject sundew_prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        resp_timer -=Time.deltaTime;
        if (resp_timer <= 0)
        {
            Instantiate(sundew_prefab, transform.position, sundew_prefab.transform.rotation, null);
            resp_timer = resp_cd;
        }

        
    }
}
