using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace S3
{
public class PlayerMovement : NetworkBehaviour {

	Rigidbody rigid;

	[SerializeField] float moveSpeed;
	public GameObject explosionSound;
	
	void Awake()
	{
		rigid = GetComponent<Rigidbody> ();
	}

	void Update()
	{
		if (!isLocalPlayer)
		{
			return;
		}
		float moveX = Input.acceleration.x;
    	float moveY = Input.acceleration.y;
        
        Vector3 posisi = new Vector3(moveX,0f,moveY);

        rigid.AddForce(posisi*moveSpeed);
	}
}
}