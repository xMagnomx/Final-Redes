﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Photon.PunBehaviour
{
	public int life;
	public float speed;

	GunController gunController;

	private Rigidbody _rb;
	

	void Start()
    {
		_rb = GetComponent<Rigidbody>();
		gunController = GetComponent<GunController>();
    }


    void Update()
    {
        //photonView.RPC("OnTriggerEnter", PhotonTargets.All);
    }

	public void Move(Vector3 dir)
	{
		_rb.velocity = dir * speed;
	}

	public void LookPoint(Vector3 lookPoint)
	{
		Vector3 correctdPoint = new Vector3(lookPoint.x,transform.position.y,lookPoint.z);
		transform.LookAt(correctdPoint);
	}

	public void Shoot()
	{
		gunController.ShootFire();
	}

	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if(stream.isWriting)
		{
			
		}else
		{

		}
	}
}
