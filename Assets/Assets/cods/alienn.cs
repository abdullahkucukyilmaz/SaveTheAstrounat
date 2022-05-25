using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienn : MonoBehaviour
{

	float dirX, moveSpeed = 10f;
	bool moveRight = true;

	// Update is called once per frame
	void Update()
	{
		if (transform.position.x > 12f)
			moveRight = false;
		if (transform.position.x < -12f)
			moveRight = true;

		if (moveRight)
			transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
		else
			transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
	}
}