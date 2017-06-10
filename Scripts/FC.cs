/// <summary>
/// Heroes And Generals Manager
/// Author: Dirk Peeters
/// Mail: ict-dirk.peeters@Telenet.be
/// 
/// FC.cs
/// 
/// </summary>
/// 
using System.Collections;
using System.Linq;
//using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




	public class FC {
	// Lists
	Dictionary<int, GameObject> objects = new Dictionary<int, GameObject>();
	GameObject[] objs;
	static int[] vals;
	// Use this for initialization
	void Start () {
		vals = new int[]{1, 2, 3, 4};
		foreach (int v in vals) {
			GameObject go = new GameObject ();
			objects.Add (v, go);
			if (GameControl.control.IsDebugging) {
				Debug.Log (v + " = " + go.name + " : " + GetID(go));
			}

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// functions testing stuff
	// get gameObject ID
	public static int GetID(GameObject go){
		int result = go.GetInstanceID ();
		return result;
	}

	public static int StringToInt(string word){
		int result = int.Parse (word);
			
		return result;
	}

	public static float StringToFloat(string word){
		float result = float.Parse (word);

		return result;
	}


}
