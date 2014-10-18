using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPoolController : MonoBehaviour {
	// 1. pool
	private static Dictionary<string, ArrayList> Pool = 
	new Dictionary<string, ArrayList> {
		{"Ball2", new ArrayList()}
	};

	// 在hierarchy中建立一个空物体，作为pool中物体的父物体
	private static GameObject containerObject;

	// 2. 取出object GetObject
	public static GameObject GetObject(string type, Vector3 position, Quaternion quat){
		GameObject o;
		ArrayList a = Pool [type] as ArrayList;
		if(a.Count > 0){
			o = a[0] as GameObject;
			a.RemoveAt(0);
		} else {
			o = Instantiate(Resources.Load("Prefabs/" + type), position, quat) as GameObject;
			o.name = type;
			o.transform.parent = null;
		}
		o.transform.position = position;
		o.transform.rotation = quat;
		o.SetActive(true);

		(o.GetComponent<BallC>()).Init();

		return o;
	}

	// 3. 往对象池存object ReturnObject
	public static void ReturnObject(GameObject o) {
		// o.name ball

		if(containerObject == null) {
			containerObject = new GameObject("ObjectPool");
		}
		o.GetComponent<BallC>().Dispose();
		o.transform.parent = containerObject.transform;
		o.SetActive(false);

		ArrayList a = Pool[o.name] as ArrayList;
		a.Add(o);
	}


}
