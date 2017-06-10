using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <ToDo>
/// check code.
/// </ToDo>

public class CharacterHolder : MonoBehaviour {
	public Text CharacterName;
	public RawImage CharacterImage;
	public RawImage CharacterRank;
	public RawImage CharacterFaction;
	public Text CharacterRankName;
	public Text CharacterType;

	public Button CharacterUpgrade;
	public Button CharacterCareerSwitch;
	public Button CharacterEditName;
	public Button EditEnd;

	public Dropdown cSwitch;

	public Toggle ToggleGold;

	public InputField Rename;
	//public List<Assault_Team> assault_teams;

	private bool isEdit = false;

	public void Edit(){
		Debug.Log (isEdit);
		Rename.gameObject.SetActive (true);
	}

	void Update(){
		if (!isEdit) {
			//Debug.Log (isEdit);
		}
	}

}
