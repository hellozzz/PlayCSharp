using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal") * speed;
		float v = Input.GetAxis ("Vertical") * speed;
		transform.Translate( new Vector3(h, v, 0) );
	}
}
