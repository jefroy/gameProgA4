﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform spawn1, spawn2;
    public GameObject enemy1, enemy2, enemiesParentGO;
    public float timer, timerMax;
    public bool canSpawn;
    public int enemies, maxEnemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = 1;
        maxEnemies = 4 + 1;
        timer = timerMax = 5f;
        canSpawn = false;
        spawn1 = gameObject.transform.Find("spawn1");
        spawn2 = gameObject.transform.Find("spawn2");
        enemiesParentGO = GameObject.Find("Enemies");
    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.Find("Enemies").transform.childCount;
        CheckTimer();
        //print(GameManager.instance.timeElapsed);
    }

    void CheckTimer()
    {
        timer += Time.deltaTime;
        if ((int)timer % 5 == 0 && enemies < maxEnemies && !GameManager.instance.win)
        {
            canSpawn = true;
            //timer = timerMax;
            Spawn();
        }
        else canSpawn = false;
    }

    public void Spawn()
    {
        if (!canSpawn) return;
        //print("tryna spawn");
        Vector3 temp;

        temp = spawn1.transform.InverseTransformVector(spawn1.position);
        temp.z = 0;
        Instantiate(
            enemy1,
            temp,
            Quaternion.identity)
            .transform.parent = enemiesParentGO.transform;

        temp = spawn2.transform.InverseTransformVector(spawn2.position);
        temp.z = 0;
        Instantiate(
            enemy2,
            temp,
            Quaternion.identity)
            .transform.parent = enemiesParentGO.transform;


    }
}
