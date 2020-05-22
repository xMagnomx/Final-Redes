using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Photon.PunBehaviour
{
	public int life;
	public int maxLife;

	public float speed;

	public HealthBar healthbar;

	GunController gunController;

	private Rigidbody _rb;


	void Start()
	{

		life = maxLife;
		healthbar.SetMaxHealth(maxLife);

		_rb = GetComponent<Rigidbody>();
		gunController = GetComponent<GunController>();
	}


	void Update()
	{

	}

	public void Move(Vector3 dir)
	{
		_rb.velocity = dir * speed;
	}

	public void LookPoint(Vector3 lookPoint)
	{
		Vector3 correctdPoint = new Vector3(lookPoint.x, transform.position.y, lookPoint.z);
		transform.LookAt(correctdPoint);
	}

	[PunRPC]
	public void Shoot()
	{
		gunController.ShootFire();
	}

	[PunRPC]
	public void TakeDmgRpc()
	{
		TakeDmg(1);
	}

	public void TakeDmg(int dmg)
	{
		life -= dmg;
		healthbar.SetHealth(life);
	}

	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if(stream.isWriting)
		{
			stream.SendNext(transform.forward);
			stream.SendNext(speed);
			stream.SendNext(life);
		}else
		{
			transform.forward =(Vector3)stream.ReceiveNext();
			speed = (float)stream.ReceiveNext();
			life = (int)stream.ReceiveNext();
		}
	}
}
