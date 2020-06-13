using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZ : MonoBehaviour
{
    public GameManagerScript gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coffin") 
        {
            other.gameObject.GetComponent<CoffinController>().fall = true;
            gameManager.LevelFailed = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
