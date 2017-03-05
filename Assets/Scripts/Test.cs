using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public GameObject building;
    public int NumberOfBuildings;

    public GameObject npc;
    public int NumberOfNpc;

    public GameObject mrRed;

    void Start()
    {
        for (int i = 0; i < NumberOfBuildings; i++)
        { 
            Vector3 pos = new Vector3(Random.Range(-50f, 50), 0.5f, Random.Range(-50f, 50));
            building.transform.localScale = new Vector3(1, Random.Range(1, 20),1);
            Instantiate(building, pos, Quaternion.identity);
        }

        
        for (int i = 0; i < NumberOfNpc; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-50f, 50), 0.5f, Random.Range(-50f, 50));
            Instantiate(npc, pos, Quaternion.identity);
        }

        Vector3 redPos = new Vector3(Random.Range(-50f, 50), 0.5f, Random.Range(-50f, 50));
        Instantiate(mrRed, redPos, Quaternion.identity);
    }
}
