using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public float force;
	// Use this for initialization
	void Start () {
		rigidbody.AddForce ( Vector3.forward * force );

		Destroy (gameObject, 1f);
	}

}
