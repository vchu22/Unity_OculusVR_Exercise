﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStat : MonoBehaviour {
    public int score;
    public GameObject targetPrefab;
    int totalTargets;
    System.Random rand = new System.Random();
	// Use this for initialization
	void Start () {
        score = 0;
        totalTargets = rand.Next(15);
        for (int i = 0; i < totalTargets; i++)
            generateTargets();
        Debug.Log("The room has a total of "+ totalTargets + " targets");
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void generateTargets()
    {
        float x = rand.Next(-499, 499) * 0.01f,
            y = 1.3f,
            z = rand.Next(-499, 499) * 0.01f;
        Vector3 pos = new Vector3(x, y, z);
        GameObject newTarget = Instantiate(targetPrefab, pos, Quaternion.identity);
    }
}