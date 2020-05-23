using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : Photon.PunBehaviour
{
	public Transform weaponHold;
	public Gun startingGun;
	Gun equippedGun;

	private void Start()
	{
		if (startingGun != null)
		{
			EquipGun(startingGun);
		}
	}
	public void EquipGun(Gun gunToEquip)
	{
		if (equippedGun != null)
		{
			Destroy(equippedGun.gameObject);
		}
		equippedGun = Instantiate(gunToEquip,weaponHold.position,weaponHold.rotation) as Gun;
		equippedGun.transform.parent = weaponHold;
	}

	public void ShootFire()
	{
		if (equippedGun != null)
		{
			equippedGun.Fire();
		}
	}
}
