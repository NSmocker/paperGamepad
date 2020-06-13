using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int hp=100;
    bool isDead;
    public Animator anim;
    int prev_hp;
    public GameObject blowGlassEffects;

    public GameObject dmg_show;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void InstantEffect()
    {
        var effect = Instantiate(blowGlassEffects,transform.position,dmg_show.transform.rotation,null);
      
        Destroy(effect, 3f);
        Destroy(gameObject,1f);

    }
    public void InstantDamage()
    {
        var go = Instantiate(dmg_show,transform.position+Vector3.up,transform.rotation,null);
       // go.transform.LookAt(GameObject.Find("Player").transform.position);
        Destroy(go, 3f);
    }
    // Update is called once per frame
    void Update()
    {
        if (RightGamePadInput.tri == true) hp = 0;
        anim.SetBool("isDead", isDead);
        if (hp <= 0 && isDead==false) {
            isDead = true;

        } 

        
    }
}
