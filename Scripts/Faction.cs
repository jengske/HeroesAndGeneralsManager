using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// needed for filehandling
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;


[Serializable]
public class Faction {
	
	[NonSerialized] public FactionHolder FactionPrefab;


	// Faction Stats //
	#region characters owned
	// characters owned
	public int TotalOwnedChar { get ; set ; }

	public int TotalOwnedCharInf { get ; set ; }

	public int TotalOwnedCharRec { get ; set ; }

	public int TotalOwnedCharPar { get ; set ; }

	public int TotalOwnedCharTan  { get ; set ; }

	public int TotalOwnedCharPil { get ; set ; }

	public int TotalOwnedCharGen { get ; set ; }

	#endregion characters owned

	#region assault teams
	// assault teams owned
	// infantry
	public int TotalGuards { get ; set ; }

	public int TotalMguards { get ; set ; }

	public int TotalInfantry { get ; set ; }

	public int TotalMinfantry { get ; set ; }

	public int TotalMechInfantry { get ; set ; }

	// recon
	public int TotalRecon { get ; set ; }

	public int TotalMrecon { get ; set ; }

	public int TotalMechRecon { get ; set ; }

	// para
	public int TotalPathfinders { get ; set ; }

	public int TotalParatroopers  { get ; set ; }


	// tank
	public int TotalLightArmor { get ; set ; }

	public int TotalMediumArmor { get ; set ; }

	public int TotalHeavyArmor { get ; set ; }

	public int TotalDestroyers { get ; set ; }


	// fighters
	public int TotalReconFighters { get ; set ; }


	public int TotalFighterSquadrons { get ; set ; }
		
	public int TotalHeavyFighterSquadrons { get ; set ; }

	#endregion assault teams

	#region commandPoints
	public int TotalCommandPoints{ get ; set ; }

	#endregion commandPoints

	// Faction information //
	public int ID { get ; set ; }

	public string Name { get ; set ; }

	public string Tag { get ; set ; }

	public Texture Flag { get ; set ; }

	public readonly Dictionary<Character.C_Rank, Texture> Ranks = new Dictionary<Character.C_Rank, Texture> ();

	public readonly List<Character> Characters = new List<Character> ();

	public readonly List<AssaultTeam> AssaultTeams = new List<AssaultTeam> ();

	public Dictionary<int,Deploydata> AssaultTeamsdeployed = new Dictionary<int, Deploydata> ();

	public Faction FactionClass{ get; set; }

	public readonly List<string> CharactersNames = new List<string> ();

	public readonly List<string> ATNames = new List<string> ();

}

