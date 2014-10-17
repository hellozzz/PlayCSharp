using UnityEngine;
using System.Collections;

public class AutoExplodeC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(Explode());
	}
	
	// 协程多用来实现延时、延迟效果
	IEnumerator Explode() {
		yield return new WaitForSeconds(3f);
		Destroy(gameObject);
		Instantiate(Resources.Load("Prefabs/Explosion"), transform.position, transform.rotation);
	}
}
