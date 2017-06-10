using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class PlayerData{
	public DateTime date;
	public int Totalsaved;
	public bool isDebugging;
	public bool isFirstTimeRun;
	public bool isSaved;

	// Currency data
	public int credits;
	public int warfunds;
	public int gold;

	// Player data
	public string clanName;
	public string inGameName;
	public int warCount;

	public string currentfaction; //prefered faction

	// Factions
	public Faction USFaction;
	public Faction GERMANFaction;
	public Faction SOVIETFaction;


	public Dictionary<string, int> USdeployed;
	public Dictionary<string, int> GERMdeployed;
	public Dictionary<string, int> SOVdeployed;

	// characters
	public List<CharacterData> Characters;
	public List<ATData> Assaultteams;

	public Dictionary<int,Deploydata> US_AssaultTeamsdeployed;
	public Dictionary<int,Deploydata> GERMAN_AssaultTeamsdeployed;
	public Dictionary<int,Deploydata> SOVIET_AssaultTeamsdeployed;

	public Dictionary<DateTime,PlayerData> SavedGames;

	public List<string> SavedSessions;

	// Warmanager
	public int DeployCounter;
	public int war; 
	public int wlc;
	public int wc;
	public Dictionary<int, WARData> WarList;
}
