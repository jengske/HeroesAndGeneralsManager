using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditBar : MonoBehaviour {
	//reference
	public static CreditBar creditBar;
	// Reference GameControl
	private GameControl ctrl;
	// the output on screen
	public Text credits;
	public Text warfunds;
	public Text gold;

//	void Awake () {
//		if (creditBar == null) {
//			DontDestroyOnLoad (gameObject);
//			creditBar = this;
//		} else if (creditBar != this) {
//			Destroy (gameObject);
//		}
//	}
	// Use this for initialization
	void Start () {
		ctrl = GameControl.control;
		credits.text = ctrl.Credits.ToString();
		warfunds.text = ctrl.Warfunds.ToString();
		gold.text = ctrl.Gold.ToString();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		ctrl = GameControl.control;
		credits.text = ctrl.Credits.ToString();
		warfunds.text = ctrl.Warfunds.ToString();
		gold.text = ctrl.Gold.ToString();
	}
}
