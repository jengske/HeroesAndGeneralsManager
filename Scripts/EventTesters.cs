using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTesters : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		EventManager.ResetDay ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnEnable(){
		EventManager.endOfDayMethods += Test ;
	}

	public void OnDisable(){
		EventManager.endOfDayMethods -= Test ;
	}

	void Test(){
		Debug.LogWarning ("Event is calling Test()");
	}
}
