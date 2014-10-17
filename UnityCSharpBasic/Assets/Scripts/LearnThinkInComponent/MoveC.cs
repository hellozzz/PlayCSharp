using UnityEngine;
using System.Collections;

// Unity 的 Component 机制是把脚本要实现的功能分开
public class MoveC : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		rigidbody.AddForce(Vector3.up * speed);
	}
	

}
