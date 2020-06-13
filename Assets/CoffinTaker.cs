using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffinTaker : MonoBehaviour
{
    public GameManagerScript manager;
    //Скріпт, який через Тріггер буде знищувати негрів та начисляти бали.
    // Start is called before the first frame update
    void Start()
    {
      //  GameObject.Find("GameManager").GetComponent<GameManagerScript>();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Coffin")
        {
            manager.CoffingsComes++;
            Destroy(collision.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
