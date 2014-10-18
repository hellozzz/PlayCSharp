using UnityEngine;
using System.Collections;

public class BallC : MonoBehaviour {

	public float force;
	public float lifetime = 3f;
	// Use this for initialization
	void Start () {
		Init();
	}

	public void Init() {
		rigidbody.AddForce(Vector3.forward * force);
		StartCoroutine(ReturnIt());
	}

	public void Dispose() {
		rigidbody.velocity = Vector3.zero;
		rigidbody.angularVelocity = Vector3.zero;
	}

	IEnumerator ReturnIt() {
		yield return new WaitForSeconds(lifetime);
		ObjectPoolController.ReturnObject(gameObject);
//		gameObject.SetActive(false);
		Instantiate(Resources.Load("Prefabs/Explosion"),transform.position, transform.rotation);
	}
}
