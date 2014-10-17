using UnityEngine;
using System.Collections;

public class RotateC : MonoBehaviour {

	public float rotateSpeed;
	void Start () {
		rigidbody.AddTorque(Vector3.up * rotateSpeed);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
