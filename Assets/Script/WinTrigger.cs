using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour {

	public GameObject gameOver;

	void OnTriggerEnter(Collider col)
	{
		if (col.CompareTag ("Player"))
		{
			gameOver.SetActive(true);
		}
	}
}
