using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InfoShow : MonoBehaviour {
	public RectTransform rankSpawn;
	public GameObject prefab;

	// Use this for initialization
	void Start () {
		
	}
	
	public void USRanks(){
		var children = new List<GameObject> ();
		foreach (Transform child in rankSpawn.transform) {
			children.Add (child.gameObject);
			//Debug.Log (child.name);
		}
		if (children.Count > 0) {
			children.ForEach (child => Destroy (child));
		}

		foreach(KeyValuePair<Character.C_Rank, Texture> f in FactionManager.control.USFaction.Ranks){
			GameObject go = Instantiate(prefab) as GameObject;
			go.transform.SetParent(rankSpawn.transform);
			go.GetComponent<gettxtAndImg> ().txt.text = f.Key.ToString ();
			go.GetComponent<gettxtAndImg> ().img.texture = f.Value;
		}
	}

	public void GermRanks(){
		var children = new List<GameObject> ();
		foreach (Transform child in rankSpawn.transform) {
			children.Add (child.gameObject);
			//Debug.Log (child.name);
		}
		if (children.Count > 0) {
			children.ForEach (child => Destroy (child));
		}

		foreach(KeyValuePair<Character.C_Rank, Texture> f in FactionManager.control.GERMANFaction.Ranks){
			GameObject go = Instantiate(prefab) as GameObject;
			go.transform.SetParent(rankSpawn.transform);
			go.GetComponent<gettxtAndImg> ().txt.text = f.Key.ToString ();
			go.GetComponent<gettxtAndImg> ().img.texture = f.Value;
		}
	}

	public void SOVRanks(){
		var children = new List<GameObject> ();
		foreach (Transform child in rankSpawn.transform) {
			children.Add (child.gameObject);
			//Debug.Log (child.name);
		}
		if (children.Count > 0) {
			children.ForEach (child => Destroy (child));
		}

		foreach(KeyValuePair<Character.C_Rank, Texture> f in FactionManager.control.SOVIETFaction.Ranks){
			GameObject go = Instantiate(prefab) as GameObject;
			go.transform.SetParent(rankSpawn.transform);
			go.GetComponent<gettxtAndImg> ().txt.text = f.Key.ToString ();
			go.GetComponent<gettxtAndImg> ().img.texture = f.Value;
		}
	}
}
