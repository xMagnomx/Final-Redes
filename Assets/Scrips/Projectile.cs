using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : Photon.PunBehaviour
{
	float _speed;
	int _dmg;

	Rigidbody _rb;

	private void Start()
	{
		_rb = GetComponent<Rigidbody>();
		GameObject.Destroy(this.gameObject, 3);
	}

	public void SetSpeed(float newSpeed)
	{
		_speed = newSpeed;
	}

	public void SetDmg(int newDmg)
	{
		_dmg = newDmg;
	}

	private void FixedUpdate()
	{
		_rb.velocity = this.transform.forward * _speed * Time.fixedDeltaTime;
	}

	private void OnTriggerEnter(Collider other)
	{
		GameObject.Destroy(this.gameObject);
		if (other.gameObject.GetComponent<Character>())
		{
			other.gameObject.GetComponent<Character>().TakeDmg(_dmg);
		}
	}
}
