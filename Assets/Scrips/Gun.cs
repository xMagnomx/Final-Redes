using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Photon.PunBehaviour
{
	public Transform muzzle;
	public Projectile projectile;
	public float msBetweenShots = 100;
	public float muzzleVelocity = 35;

	float nextShotTime;

	public void Fire()
	{
		if (Time.time > nextShotTime)
		{
			nextShotTime = Time.time + msBetweenShots / 1000;
			//Projectile newProjectile = PhotonNetwork.Instantiate("bullet", muzzle.position, muzzle.rotation,0);
			//newProjectile.SetSpeed(muzzleVelocity);
		}
	}
}
