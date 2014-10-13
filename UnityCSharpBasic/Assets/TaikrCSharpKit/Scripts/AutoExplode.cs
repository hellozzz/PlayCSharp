using UnityEngine;
using System.Collections;

public class AutoExplode : MonoBehaviour {

	public float lifetime;
	// Use this for initialization
	void Start () {
	
		
		StartCoroutine ( Explode () );
	}
	
	IEnumerator Explode()
	{
		yield return new WaitForSeconds ( lifetime );
		Done_ObjectPool.ReturnObject (gameObject);
		gameObject.SetActive (false);
		//Destroy (gameObject);
		Instantiate ( Resources.Load ("Prefabs/Explosion"), transform.position, transform.rotation);
	}
}
