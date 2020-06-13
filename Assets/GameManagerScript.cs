using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public bool StartLevel;
    public bool LevelFailed;
    public bool Victory;

    public int CoffingsToSpawn;
    public int CoffingsComes;
    public int CoffingsNeedToCome;



    [Header("Spawn Mechanic")]
    public GameObject spawner;
    public GameObject Prefab;

    public float spawn_cd;



    static public float stayTimer = -1;
    public List<CoffinController> coffins;

    [Header("UI")]
    public TextMeshPro coffinCountUi;

    public void UpdateUI()
    {

        coffinCountUi.text =
            "Coffin Need to Spawn: " + CoffingsNeedToCome.ToString() + "\n" +
            "Coffings Comes: " + CoffingsComes.ToString();
        if (Victory) coffinCountUi.text = "Victory";


    }


    public void LostTar() 
    {
        Time.timeScale = 0;

    }
    public void FoundTar()
    {
        Time.timeScale = 1;

    }


    public void SpawnCoffin() 
    {
        spawn_cd -= Time.deltaTime;
        if (CoffingsToSpawn > 0) { 
            if (spawn_cd <= 0) 
            {
                spawn_cd = 2f;
                Instantiate(Prefab, spawner.transform.position, spawner.transform.rotation);
                CoffingsToSpawn--;
            }
        }

    }

    //Проверяет есть ли новые негры, если есть добавляет их в список, и обновляет их
    //состояние.
    public void UpdateCoffins()
    {
        if (stayTimer > -5) stayTimer -= Time.deltaTime;
        var array = GameObject.FindGameObjectsWithTag("Coffin");
        coffins.Clear();
        foreach (GameObject x in array) { coffins.Add(x.GetComponent<CoffinController>()); }
        if (stayTimer < 0) {} else { StartLevel = false;}
        foreach (CoffinController x in coffins){ x.walk = StartLevel; }


        if (LevelFailed) { StartLevel = false; foreach (CoffinController x in coffins) { x.pressF = true; } }



    }


    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.Find("Spawner");
    }

    // Update is called once per frame
    void Update()
    {
        if (CoffingsNeedToCome == CoffingsComes) Victory = true;
        UpdateCoffins(); SpawnCoffin();
        UpdateUI();
    }
}
