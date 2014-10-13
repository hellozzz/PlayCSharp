using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

	public float rotateSpeed;

	void Start () {
		rigidbody.AddTorque (Vector3.up * rotateSpeed);
	}
	

}
