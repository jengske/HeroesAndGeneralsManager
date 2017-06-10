using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetText : MonoBehaviour {
	public Text msg;
	private string DefaultWarn = "Enter all fields";

	// Use this for initialization
	void Start () {

		msg.text = DefaultWarn;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClose(){
		Destroy (gameObject);
	}
}
