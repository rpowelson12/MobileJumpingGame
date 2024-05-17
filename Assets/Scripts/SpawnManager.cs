using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private Platform prefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPlatform", 0f, 3.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnPlatform(){
        Vector3 randomSpawnPosition = new Vector3(ChooseRandomXPosition(), transform.position.y, 0);
        Instantiate(prefab,randomSpawnPosition,transform.rotation);
    }

    private int ChooseRandomXPosition()
    {
        return UnityEngine.Random.Range(-7,8);
    }
}
