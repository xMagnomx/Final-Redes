using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	public float speed = 10;
    public float DieBullet;

	public void SetSpeed(float newSpeed)
	{
		speed = newSpeed;
	}

    void Update()
    {
		transform.Translate(Vector3.forward * Time.deltaTime * speed);

        DieBullet++;
        if (DieBullet > 300)
            Destroy(this.gameObject);
    }
}
