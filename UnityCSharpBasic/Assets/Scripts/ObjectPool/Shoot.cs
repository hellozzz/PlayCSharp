using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Transform shootPos;
	public GameObject projectile;

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			ObjectPoolController.GetObject("Ball2", shootPos.position, shootPos.rotation);
		}
	}
}
