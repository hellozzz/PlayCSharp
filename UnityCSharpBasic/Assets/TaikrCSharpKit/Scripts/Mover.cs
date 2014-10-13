using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed;

	void Start () {
		rigidbody.AddForce ( Vector3.up * speed );
	}

}
