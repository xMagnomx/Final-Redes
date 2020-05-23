using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammunition : Photon.PunBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //tiene que da municion
            //photonView.RPC("OnTriggerEnter", PhotonTargets.All, other.gameObject);
            PhotonNetwork.
            Destroy(this.gameObject);

        }

    }
    [PunRPC]
    void fjjffj()
    {

    }
}
