using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetManager : Photon.PunBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		PhotonNetwork.ConnectUsingSettings("v1.0");
    }

	public override void OnConnectedToPhoton()
	{
		print("connectado a photon");
	}

	public override void OnConnectedToMaster()
	{
		print("conectado al servidor");

		var options = new RoomOptions();

		options.MaxPlayers = 10;

		PhotonNetwork.JoinOrCreateRoom("tutorial photon",options,TypedLobby.Default);
	}

	public override void OnCreatedRoom()
	{
		print("cree un room");
	}

	public override void OnJoinedRoom()
	{
		print("me joinee");
		PhotonNetwork.Instantiate("Pj",Vector3.zero,Quaternion.identity,0);
	}
	// Update is called once per frame
	void Update()
    {
        
    }
}
