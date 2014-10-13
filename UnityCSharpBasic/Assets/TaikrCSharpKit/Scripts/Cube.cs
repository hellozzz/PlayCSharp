using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour 
{

	public float speed;
	public float rotateSpeed;
	// Use this for initialization
	void Start () 
	{
		rigidbody.AddForce ( Vector3.up * speed );
		rigidbody.AddTorque (Vector3.up * rotateSpeed);

		StartCoroutine ( Explode () );
	}

	IEnumerator Explode()
	{
		yield return new WaitForSeconds (3f);
		Destroy (gameObject);
		Instantiate ( Resources.Load ("Prefabs/Explosion"), transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
