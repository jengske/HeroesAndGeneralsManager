using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {
	public delegate void endOfDay ();
	public static event endOfDay endOfDayMethods;


	public static void ResetDay(){
		endOfDayMethods ();
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

