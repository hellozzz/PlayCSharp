using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public Transform shootPos;

	public GameObject projectile;

	// Update is called once per frame
	void Update () {
		if ( Input.GetButtonDown ("Fire1") ) 
		{
			Instantiate( projectile, shootPos.position,	shootPos.rotation );
		}
	}
}
