using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : Photon.PunBehaviour
{
    public List<GameObject> wayPoint = new List<GameObject>();
    //public GameObject Ammunition;
    float seconds = 0;
    void Start()
    {
       
        
    }
    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds > 2)
        {
            print("spanw");
            jaja();
            seconds = 0;
        }

    }
    void jaja()
    {
        GameObject spawnAmmunition = PhotonNetwork.Instantiate("muni", wayPoint[Random.Range(0, wayPoint.Count)].transform.position, Quaternion.identity, 1);

    }
}
