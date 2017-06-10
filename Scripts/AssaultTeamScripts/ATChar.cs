using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class ATChar : MonoBehaviour {
	public Text _Name;
	public RawImage _Icon;
	public Text _Rank;
	public RawImage _Flag;
	public Text _FactionName;

	// buttons
	public Button _Guard;
	public Button _Recon;
	public Button _Armor;
	public Button _Para;
	public Button _Fighters;

	public Button _addCom;

	// CommandPoints
	public RectTransform _CP;



}
