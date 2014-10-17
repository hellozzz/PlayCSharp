using UnityEngine;
using System.Collections;

// 而 Unity 的 Component 机制是把脚本要实现的功能分开
// 参考 MoveC.cs, RotateC.cs, AutoExplodeC 和场景中的 SplitScriptAsComponent 
public class CubeController : MonoBehaviour {

	public float speed;
	public float rotateSpeed;

	// Use this for initialization
	void Start () {
		// 产生上升动作
		rigidbody.AddForce(Vector3.up * speed);
		// 产生旋转
		rigidbody.AddTorque(Vector3.up * rotateSpeed);

		StartCoroutine(Explode());
	}

	// 协程多用来实现延时、延迟效果
	IEnumerator Explode() {
		yield return new WaitForSeconds(3f);
		Destroy(gameObject);
		Instantiate(Resources.Load("Prefabs/Explosion"), transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
