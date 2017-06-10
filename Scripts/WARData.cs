using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class WARData {
	[NonSerialized]private GameControl GC = GameControl.control;

	private DateTime StartTime; 
	private DateTime EndTime;

	public string Username;

	public string preferedFaction;

	private int WarCount;

	public int BeginCredit;
	public int BeginWarfunds;
	public int BeginGold;

	public int CurCredit;
	public int CurWarfunds;
	public int CurGold;

	public int EndCredit;
	public int EndWarfunds;
	public int EndGold;

	public List<int> CostsInCredits;
	public List<int> CostsInWarfunds;
	public List<int> CostsInGold;

	public int TotalCreditCosts;
	public int TotalWarfundsCosts;
	public int TotalGoldCosts;

	public WARData(int _WarCount){
		this.StartTime = DateTime.Today;
		this.Username = GC.inGameName;
		this.preferedFaction = GameControl.control.CurrentFaction;
		this.WarCount = _WarCount;
		GC.warCount = this.WarCount;
		this.BeginCredit = GC.Credits;
		this.BeginWarfunds = GC.Warfunds;
		this.BeginGold = GC.Gold;

		this.CurCredit = GC.Credits;
		this.CurWarfunds = GC.Warfunds;
		this.CurGold = GC.Gold;

		this.EndCredit = 0;
		this.EndWarfunds = 0;
		this.EndGold = 0;

		CostsInCredits = new List<int> ();
		CostsInWarfunds = new List<int> ();
		CostsInGold = new List<int> ();

		TotalCreditCosts = 0;
		TotalWarfundsCosts = 0;
		TotalGoldCosts = 0;


		Debug.LogWarning ("new warData started on " + StartTime.ToString());
	}

	public DateTime GetStartTime(){
		return StartTime;
	}

	public DateTime SetEndTime(){
		return EndTime = DateTime.Today;

	}

	public void SetInCredits(int amount){
		CostsInCredits.Add (amount);

	}

	public void SetInWarfundss(int amount){
		CostsInWarfunds.Add (amount);

	}

	public void SetInGold(int amount){
		CostsInGold.Add (amount);

	}

	public int CalculateCreditCosts(){
		for (int cr = 0; cr <= CostsInCredits.Count -1; cr++) {
			TotalCreditCosts += CostsInCredits [cr];

		}

		return TotalCreditCosts;
	}

	public int CalculateWarfundsCosts(){

		for (int cr = 0; cr <= CostsInWarfunds.Count -1; cr++) {
			TotalWarfundsCosts += CostsInWarfunds [cr];

		}

		return TotalWarfundsCosts;
	}

	public int CalculateGoldCosts(){

		for (int cr = 0; cr <= CostsInGold.Count -1; cr++) {
			TotalGoldCosts += CostsInGold [cr];

		}

		return TotalGoldCosts;
	}


}
