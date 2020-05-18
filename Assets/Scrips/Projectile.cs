using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : Photon.PunBehaviour
{
	public float speed = 10;
    float DieBullet;

	public void SetSpeed(float newSpeed)
	{
		speed = newSpeed;
	}

    void Update()
    {
		transform.Translate(Vector3.forward * Time.deltaTime * speed);

		DieBullet += Time.deltaTime;
        if (DieBullet > 3)
            Destroy(this.gameObject);
    }
}
