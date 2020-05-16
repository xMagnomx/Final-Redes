using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Photon.PunBehaviour
{
	private Character _owner;

	Vector3 _targetDir;

	Camera _viewCamera;

    void Start()
    {
		_owner = this.GetComponent<Character>();
		_viewCamera = Camera.main;

		if (!photonView.isMine)
		{
			Destroy(this.GetComponent<Rigidbody>());
			Destroy(this);
		}
    }

    // Update is called once per frame
    void Update()
    {
		_targetDir.x = Input.GetAxis("Horizontal");
		_targetDir.y = 0;
		_targetDir.z = Input.GetAxis("Vertical");

		_owner.Move(_targetDir);

		// Apunta a donde este el mouse
		Ray ray = _viewCamera.ScreenPointToRay(Input.mousePosition);
		Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
		float rayDistance;
		if (groundPlane.Raycast(ray, out rayDistance))
		{
			Vector3 point = ray.GetPoint(rayDistance);
			_owner.LookPoint(point);
		}


		if (Input.GetMouseButton(0))
		{
			//disparar
		}
	}
}
