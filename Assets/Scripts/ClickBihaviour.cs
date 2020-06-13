using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickBihaviour : MonoBehaviour
{

   public  int HP;
   public TextMeshPro HP_UI;


    // Start is called before the first frame update
    void Start()
    {
          HP = 5;
    }



    void OnMouseDown()
    {
      HP= HP-1;
    }

    // Update is called once per frame
    void Update()
    {
        HP_UI.text = HP.ToString();
        if (HP < 0) Destroy(gameObject);
    }
}
