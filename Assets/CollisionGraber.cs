using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGraber : MonoBehaviour
{
    public Collider my_collider;
    // Start is called before the first frame update
    public GameObject smth;

    
    void Start()
    {
        smth = my_collider.gameObject;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
