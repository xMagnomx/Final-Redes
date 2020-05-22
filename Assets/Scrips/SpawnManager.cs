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

		if (seconds > 3)
        {
            print("spanw");

			//PhotonNetwork.Instantiate("muni", wayPoint[Random.Range(0, wayPoint.Count)].transform.position, Quaternion.identity, 0);

			seconds = 0;
        }

    }
}
