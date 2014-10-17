using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour 
{
	// 1.pool
	private static Dictionary<string , ArrayList> pool = 
		new Dictionary<string, ArrayList>{
			{ "Ball", new ArrayList() }
		};

	// 2.GetObject
	public static GameObject GetObject( string type, Vector3 position, Quaternion quat )
	{
		GameObject o;
		ArrayList a = pool [type] as ArrayList;
		if (a.Count > 0) 
		{
				o = a [0] as GameObject;
				a.RemoveAt (0);
		} else 
		{
			o = Instantiate( Resources.Load("Prefabs/" + type) , position, quat ) as GameObject;
		}
		// 
		o.name = type;
		// init 

		return o;
	}

	// 3.ReturnObject
	public static void ReturnObject( GameObject o )
	{
		// o.name  Ball
		ArrayList a = pool [o.name] as ArrayList;
		a.Add (o);
		// dispose

	}









}
