using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FTR : MonoBehaviour {
	public static FTR FirstTimeRun;
	public GameControl GCref = GameControl.control;
	public GameObject FTR_Panel;
	public GameObject begin;
	public GameObject infpanel;
	public GameObject us;
	public GameObject ge;
	public GameObject so;

	#region begin
	// Begin()
	public InputField credits;
	public InputField warfunds;
	public InputField gold;
	public InputField clanName;
	public InputField inGameName;
	public InputField warCounter;
	public Dropdown preferedFaction;
	#endregion

	#region infantry
	// Infantry
	public InputField USI0;
	public InputField USI1;
	public InputField USI2;
	public InputField USI3;
	public InputField USI4;
	public InputField USI5;
	public InputField USI6;
	public InputField USI7;
	public InputField USI8;
	public InputField USI9;
	public InputField USI10;
	public InputField USI11;
	public InputField USI12;
	public InputField USI13;
	public InputField USI14;
	public InputField USI15;
	public InputField USI16;
	public InputField USI17;
	public InputField USI18;
	public InputField USI19;
	public InputField USI20;
	public InputField USI21;
	public InputField USI22;

	public InputField GEI0;
	public InputField GEI1;
	public InputField GEI2;
	public InputField GEI3;
	public InputField GEI4;
	public InputField GEI5;
	public InputField GEI6;
	public InputField GEI7;
	public InputField GEI8;
	public InputField GEI9;
	public InputField GEI10;
	public InputField GEI11;
	public InputField GEI12;
	public InputField GEI13;
	public InputField GEI14;
	public InputField GEI15;
	public InputField GEI16;
	public InputField GEI17;
	public InputField GEI18;
	public InputField GEI19;
	public InputField GEI20;
	public InputField GEI21;
	public InputField GEI22;

	public InputField SOI0;
	public InputField SOI1;
	public InputField SOI2;
	public InputField SOI3;
	public InputField SOI4;
	public InputField SOI5;
	public InputField SOI6;
	public InputField SOI7;
	public InputField SOI8;
	public InputField SOI9;
	public InputField SOI10;
	public InputField SOI11;
	public InputField SOI12;
	public InputField SOI13;
	public InputField SOI14;
	public InputField SOI15;
	public InputField SOI16;
	public InputField SOI17;
	public InputField SOI18;
	public InputField SOI19;
	public InputField SOI20;
	public InputField SOI21;
	public InputField SOI22;
	#endregion

	#region para
	// Para
	public InputField USPA0;
	public InputField USPA1;
	public InputField USPA2;
	public InputField USPA3;
	public InputField USPA4;
	public InputField USPA5;
	public InputField USPA6;
	public InputField USPA7;
	public InputField USPA8;
	public InputField USPA9;
	public InputField USPA10;
	public InputField USPA11;
	public InputField USPA12;
	public InputField USPA13;
	public InputField USPA14;
	public InputField USPA15;
	public InputField USPA16;
	public InputField USPA17;
	public InputField USPA18;
	public InputField USPA19;
	public InputField USPA20;
	public InputField USPA21;
	public InputField USPA22;

	public InputField GEPA0;
	public InputField GEPA1;
	public InputField GEPA2;
	public InputField GEPA3;
	public InputField GEPA4;
	public InputField GEPA5;
	public InputField GEPA6;
	public InputField GEPA7;
	public InputField GEPA8;
	public InputField GEPA9;
	public InputField GEPA10;
	public InputField GEPA11;
	public InputField GEPA12;
	public InputField GEPA13;
	public InputField GEPA14;
	public InputField GEPA15;
	public InputField GEPA16;
	public InputField GEPA17;
	public InputField GEPA18;
	public InputField GEPA19;
	public InputField GEPA20;
	public InputField GEPA21;
	public InputField GEPA22;

	public InputField SOPA0;
	public InputField SOPA1;
	public InputField SOPA2;
	public InputField SOPA3;
	public InputField SOPA4;
	public InputField SOPA5;
	public InputField SOPA6;
	public InputField SOPA7;
	public InputField SOPA8;
	public InputField SOPA9;
	public InputField SOPA10;
	public InputField SOPA11;
	public InputField SOPA12;
	public InputField SOPA13;
	public InputField SOPA14;
	public InputField SOPA15;
	public InputField SOPA16;
	public InputField SOPA17;
	public InputField SOPA18;
	public InputField SOPA19;
	public InputField SOPA20;
	public InputField SOPA21;
	public InputField SOPA22;
	#endregion

	#region recon
	// Recon
	public InputField USR0;
	public InputField USR1;
	public InputField USR2;
	public InputField USR3;
	public InputField USR4;
	public InputField USR5;
	public InputField USR6;
	public InputField USR7;
	public InputField USR8;
	public InputField USR9;
	public InputField USR10;
	public InputField USR11;
	public InputField USR12;
	public InputField USR13;
	public InputField USR14;
	public InputField USR15;
	public InputField USR16;
	public InputField USR17;
	public InputField USR18;
	public InputField USR19;
	public InputField USR20;
	public InputField USR21;
	public InputField USR22;

	public InputField GER0;
	public InputField GER1;
	public InputField GER2;
	public InputField GER3;
	public InputField GER4;
	public InputField GER5;
	public InputField GER6;
	public InputField GER7;
	public InputField GER8;
	public InputField GER9;
	public InputField GER10;
	public InputField GER11;
	public InputField GER12;
	public InputField GER13;
	public InputField GER14;
	public InputField GER15;
	public InputField GER16;
	public InputField GER17;
	public InputField GER18;
	public InputField GER19;
	public InputField GER20;
	public InputField GER21;
	public InputField GER22;

	public InputField SOR0;
	public InputField SOR1;
	public InputField SOR2;
	public InputField SOR3;
	public InputField SOR4;
	public InputField SOR5;
	public InputField SOR6;
	public InputField SOR7;
	public InputField SOR8;
	public InputField SOR9;
	public InputField SOR10;
	public InputField SOR11;
	public InputField SOR12;
	public InputField SOR13;
	public InputField SOR14;
	public InputField SOR15;
	public InputField SOR16;
	public InputField SOR17;
	public InputField SOR18;
	public InputField SOR19;
	public InputField SOR20;
	public InputField SOR21;
	public InputField SOR22;
	#endregion

	#region tankman
	// Tankman
	public InputField UST0;
	public InputField UST1;
	public InputField UST2;
	public InputField UST3;
	public InputField UST4;
	public InputField UST5;
	public InputField UST6;
	public InputField UST7;
	public InputField UST8;
	public InputField UST9;
	public InputField UST10;
	public InputField UST11;
	public InputField UST12;
	public InputField UST13;
	public InputField UST14;
	public InputField UST15;
	public InputField UST16;
	public InputField UST17;
	public InputField UST18;
	public InputField UST19;
	public InputField UST20;
	public InputField UST21;
	public InputField UST22;

	public InputField GET0;
	public InputField GET1;
	public InputField GET2;
	public InputField GET3;
	public InputField GET4;
	public InputField GET5;
	public InputField GET6;
	public InputField GET7;
	public InputField GET8;
	public InputField GET9;
	public InputField GET10;
	public InputField GET11;
	public InputField GET12;
	public InputField GET13;
	public InputField GET14;
	public InputField GET15;
	public InputField GET16;
	public InputField GET17;
	public InputField GET18;
	public InputField GET19;
	public InputField GET20;
	public InputField GET21;
	public InputField GET22;

	public InputField SOT0;
	public InputField SOT1;
	public InputField SOT2;
	public InputField SOT3;
	public InputField SOT4;
	public InputField SOT5;
	public InputField SOT6;
	public InputField SOT7;
	public InputField SOT8;
	public InputField SOT9;
	public InputField SOT10;
	public InputField SOT11;
	public InputField SOT12;
	public InputField SOT13;
	public InputField SOT14;
	public InputField SOT15;
	public InputField SOT16;
	public InputField SOT17;
	public InputField SOT18;
	public InputField SOT19;
	public InputField SOT20;
	public InputField SOT21;
	public InputField SOT22;
	#endregion

	#region pilot
	// Pilot
	public InputField USPI0;
	public InputField USPI1;
	public InputField USPI2;
	public InputField USPI3;
	public InputField USPI4;
	public InputField USPI5;
	public InputField USPI6;
	public InputField USPI7;
	public InputField USPI8;
	public InputField USPI9;
	public InputField USPI10;
	public InputField USPI11;
	public InputField USPI12;
	public InputField USPI13;
	public InputField USPI14;
	public InputField USPI15;
	public InputField USPI16;
	public InputField USPI17;
	public InputField USPI18;
	public InputField USPI19;
	public InputField USPI20;
	public InputField USPI21;
	public InputField USPI22;

	public InputField GEPI0;
	public InputField GEPI1;
	public InputField GEPI2;
	public InputField GEPI3;
	public InputField GEPI4;
	public InputField GEPI5;
	public InputField GEPI6;
	public InputField GEPI7;
	public InputField GEPI8;
	public InputField GEPI9;
	public InputField GEPI10;
	public InputField GEPI11;
	public InputField GEPI12;
	public InputField GEPI13;
	public InputField GEPI14;
	public InputField GEPI15;
	public InputField GEPI16;
	public InputField GEPI17;
	public InputField GEPI18;
	public InputField GEPI19;
	public InputField GEPI20;
	public InputField GEPI21;
	public InputField GEPI22;

	public InputField SOPI0;
	public InputField SOPI1;
	public InputField SOPI2;
	public InputField SOPI3;
	public InputField SOPI4;
	public InputField SOPI5;
	public InputField SOPI6;
	public InputField SOPI7;
	public InputField SOPI8;
	public InputField SOPI9;
	public InputField SOPI10;
	public InputField SOPI11;
	public InputField SOPI12;
	public InputField SOPI13;
	public InputField SOPI14;
	public InputField SOPI15;
	public InputField SOPI16;
	public InputField SOPI17;
	public InputField SOPI18;
	public InputField SOPI19;
	public InputField SOPI20;
	public InputField SOPI21;
	public InputField SOPI22;

	#endregion

	#region assaultTeams
	public InputField USG;
	public InputField USMG;
	public InputField USIN;
	public InputField USMIN;
	public InputField USMECHIN;

	public InputField USR;
	public InputField USMR;
	public InputField USMECHR;

	public InputField USLA;
	public InputField USMA;
	public InputField USDESTROY;
	public InputField USHA;

	public InputField USPATH;
	public InputField USPAR;

	public InputField USRECF;
	public InputField USMF;
	public InputField USHF;

	public InputField GEG;
	public InputField GEMG;
	public InputField GEIN;
	public InputField GEMIN;
	public InputField GEMECHIN;

	public InputField GER;
	public InputField GEMR;
	public InputField GEMECHR;

	public InputField GELA;
	public InputField GEMA;
	public InputField GEDESTROY;
	public InputField GEHA;

	public InputField GEPATH;
	public InputField GEPAR;

	public InputField GERECF;
	public InputField GEMF;
	public InputField GEHF;

	public InputField SOG;
	public InputField SOMG;
	public InputField SOIN;
	public InputField SOMIN;
	public InputField SOMECHIN;

	public InputField SOR;
	public InputField SOMR;
	public InputField SOMECHR;

	public InputField SOLA;
	public InputField SOMA;
	public InputField SODESTROY;
	public InputField SOHA;

	public InputField SOPATH;
	public InputField SOPAR;

	public InputField SORECF;
	public InputField SOMF;
	public InputField SOHF;
	#endregion

	public bool SetFTR(bool b){
		bool B = GCref.IsFirstTimeRun;
		B = b;
		return B;
	}

	public bool GetFTR(){
		//Debug.LogError (GCref.IsFirstTimeRun);
		return GCref.IsFirstTimeRun;
	}

	public void DisableFTR(){
		GCref.SetCharData ();
		GCref.SetATData ();
		FTR_Panel.SetActive (false);

		GameControl.control.IsFirstTimeRun = false;
		CanvasManager.CM.MainActive = true;

		int counter = GameControl.control.warCount;
		var WD = new WARData (counter);
		WD.BeginCredit = GameControl.control.Credits;
		WD.BeginWarfunds = GameControl.control.Warfunds;
		WD.BeginGold = GameControl.control.Gold;
		WarManager.WM.WarList.Add (counter, WD);
		Debug.LogError ("Current WAR for Europe is " + counter + " : " + WD.GetStartTime());
		WarManager.WM.setOptionList ();


		//SaveAndLoad.sal.Save ();

	}

	#region create
	public void CreateInf() {
		#region us
		if (string.IsNullOrEmpty (USI0.text)) {
			

		} else {
			for (int i = 0; i < int.Parse (USI0.text.ToString()); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (string.IsNullOrEmpty (USI1.text)) {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (string.IsNullOrEmpty (USI2.text)) {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Technician5thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

	
		if (string.IsNullOrEmpty (USI3.text)) {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (string.IsNullOrEmpty (USI4.text)) {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}

		}

		if (string.IsNullOrEmpty (USI5.text)) {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}
			
		if (string.IsNullOrEmpty (USI6.text)) {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse(USI6.text.ToString()); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (USI7.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI7.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.StaffSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (USI8.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (USI9.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (USI10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (USI11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (USI12.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (USI13.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (USI14.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (USI15.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (USI16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (USI17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("US");
				inf.C_Name = "USINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharInf += 1;
			}
		}

		if (USI18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USI19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USI20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USI21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USI22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USI22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}

		}

		#endregion us

		#region ge
		//GE
		if (GEI0.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI0.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI1.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI2.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Technician5thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI3.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI4.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI5.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI6.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI6.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI7.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI7.text); i++) {
			CharacterManager.characterManager.CharCount++;
			Character inf = new Infantry ("GERMANY");
			inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
			inf.C_DeployID = CharacterManager.characterManager.CharCount;
			inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
			inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
			inf.Rank = Character.C_Rank.StaffSergeant;
			inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

			FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
			FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI8.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}
		
		if (GEI9.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI12.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI13.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI14.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI15.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharInf += 1;
			}
		}

		if (GEI18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GEI19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GEI20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GEI21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GEI22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEI22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}


		#endregion ge

		#region sov
		// SOVIET
		if (SOI0.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI0.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}

		if (SOI1.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}
	
		if (SOI2.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}
	
		if (SOI3.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}

		if (SOI4.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}
	
		if (SOI5.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}
	
		if (SOI6.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI6.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}

		if (SOI7.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI7.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.StaffSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}

		if (SOI8.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}
	
		if (SOI9.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}
	
		if (SOI10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}

		if (SOI11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}
	
		if (SOI12.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}
	
		if (SOI13.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}

		if (SOI14.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}
	
		if (SOI15.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}

		if (SOI16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}

		if (SOI17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Infantry ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharInf += 1;
			}
		}

		if (SOI18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOI19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOI20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOI21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOI22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOI22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		#endregion sov

	}
		
	public void CreateRec() {

		#region us
		if (USR0.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR0.text.ToString()); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR1.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR2.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Technician5thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}


		if (USR3.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR4.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}

		}

		if (USR5.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR6.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse(USR6.text.ToString()); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR7.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR7.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.StaffSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR8.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR9.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR12.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR13.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR14.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR15.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("US");
				inf.C_Name = "USRNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharRec += 1;
			}
		}

		if (USR18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USR19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USR20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USR21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USR22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}

		}

		#endregion us

		#region ge
		//GE
		if (GER0.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER0.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER1.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER2.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Technician5thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER3.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER4.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER5.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER6.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER6.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER7.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER7.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.StaffSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER8.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER9.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER12.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER13.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER14.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER15.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharRec += 1;
			}
		}

		if (GER18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GER19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GER20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GER21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GER22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}


		#endregion ge

		#region sov
		// SOVIET
		if (SOR0.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR0.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR1.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR2.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR3.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR4.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR5.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR6.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR6.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR7.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR7.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.StaffSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR8.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR9.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR12.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR13.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR14.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR15.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Recon ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharRec += 1;
			}
		}

		if (SOR18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOR19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOR20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOR21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOR22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETREC" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		#endregion sov


	}

	public void CreatePar() {

		#region us
		if (USPA0.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA0.text.ToString()); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA1.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA2.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Technician5thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}


		if (USPA3.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA4.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}

		}

		if (USPA5.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA6.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse(USPA6.text.ToString()); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA7.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA7.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.StaffSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA8.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA9.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA12.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA13.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA14.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA15.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("US");
				inf.C_Name = "USPANF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPar += 1;
			}
		}

		if (USPA18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USPA19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USPA20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USPA21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USPA22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPA22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}

		}

		#endregion us

		#region ge
		//GE
		if (GEPA0.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA0.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA1.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA2.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Technician5thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA3.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA4.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA5.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA6.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA6.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA7.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA7.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.StaffSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA8.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA9.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA12.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA13.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA14.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA15.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPar += 1;
			}
		}

		if (GEPA18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GEPA19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GEPA20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GEPA21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GEPA22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPA22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}


		#endregion ge

		#region sov
		// SOVIET
		if (SOPA0.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA0.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA1.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA2.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA3.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA4.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA5.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA6.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA6.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA7.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA7.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.StaffSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA8.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA9.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA12.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA13.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA14.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA15.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Para ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPar += 1;
			}
		}

		if (SOPA18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOPA19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOPA20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOPA21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOPA22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPA22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETPAR" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		#endregion sov


	}

	public void CreateTan() {

		#region us
		if (UST0.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST0.text.ToString()); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST1.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST2.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Technician5thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}


		if (UST3.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST4.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}

		}

		if (UST5.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST6.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse(UST6.text.ToString()); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST7.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST7.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.StaffSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST8.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST9.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST12.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST13.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST14.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST15.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("US");
				inf.C_Name = "USTNF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharTan += 1;
			}
		}

		if (UST18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (UST19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (UST20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (UST21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (UST22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (UST22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}

		}

		#endregion us

		#region ge
		//GE
		if (GET0.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET0.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET1.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET2.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Technician5thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET3.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET4.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET5.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET6.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET6.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET7.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET7.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.StaffSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET8.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET9.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET12.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET13.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET14.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET15.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharTan += 1;
			}
		}

		if (GET18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GET19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GET20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GET21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GET22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GET22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}


		#endregion ge

		#region sov
		// SOVIET
		if (SOT0.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT0.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT1.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT2.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT3.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT4.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT5.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT6.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT6.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT7.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT7.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.StaffSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT8.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT9.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT12.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT13.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT14.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT15.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Tankman ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharTan += 1;
			}
		}

		if (SOT18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOT19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOT20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOT21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOT22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOT22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETTAN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		#endregion sov


	}

	public void CreatePil() {

		#region us
		if (USPI0.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI0.text.ToString()); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI1.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI2.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Technician5thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}


		if (USPI3.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI4.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}

		}

		if (USPI5.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI6.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse(USPI6.text.ToString()); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI7.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI7.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.StaffSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI8.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI9.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI12.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI13.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI14.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI15.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("US");
				inf.C_Name = "USPINF" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharPil += 1;
			}
		}

		if (USPI18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USPI19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USPI20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USPI21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}
		}

		if (USPI22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPI22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("US");
				inf.C_Name = "USGEN" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/US");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["US"].Characters.Add (inf);
				FactionManager.control.Factions ["US"].TotalOwnedCharGen += 1;
			}

		}

		#endregion us

		#region ge
		//GE
		if (GEPI0.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI0.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI1.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI2.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Technician5thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI3.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI4.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI5.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI6.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI6.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI7.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI7.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.StaffSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI8.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI9.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI12.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI13.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI14.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI15.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharPil += 1;
			}
		}

		if (GEPI18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GEPI19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GEPI20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GEPI21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}

		if (GEPI22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPI22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("GERMANY");
				inf.C_Name = "GERMANYPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/GERMANY");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["GERMANY"].Characters.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalOwnedCharGen += 1;
			}
		}


		#endregion ge

		#region sov
		// SOVIET
		if (SOPI0.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI0.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Private;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI1.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI1.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.PrivateFirstClass;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI2.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI2.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI3.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI3.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Corporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI4.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI4.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SeniorCorporal;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI5.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI5.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Technician4thGrade;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI6.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI6.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Sergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI7.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI7.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.StaffSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI8.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI8.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.TechnicalSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI9.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI9.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.MasterSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI10.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI10.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.FirstSergeant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI11.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI11.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SergeantMajor;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI12.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI12.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.SecondLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI13.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI13.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.FirstLieutenant;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI14.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI14.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Captain;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI15.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI15.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Major;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI16.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI16.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.LieutenantColonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI17.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI17.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new Pilot ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.Colonel;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharPil += 1;
			}
		}

		if (SOPI18.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI18.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.BrigadierGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOPI19.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI19.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.MajorGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOPI20.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI20.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.LieutenantGeneral;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOPI21.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI21.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.General;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		if (SOPI22.text.ToString () == "") {
			////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPI22.text); i++) {
				CharacterManager.characterManager.CharCount++;
				Character inf = new General ("SOVIET");
				inf.C_Name = "SOVIETPIL" + CharacterManager.characterManager.CharCount.ToString ();
				inf.C_DeployID = CharacterManager.characterManager.CharCount;
				inf.CharPanel = CharacterManager.characterManager.CharacterPrefab;
				inf.FactionFlag = Resources.Load<Texture> ("Images/FactionFlags/SOVIET");
				inf.Rank = Character.C_Rank.GeneralOfTheArmy;
				inf.RankIcon = FactionManager.control.getRankIcon (inf.Rank.ToString ());

				FactionManager.control.Factions ["SOVIET"].Characters.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalOwnedCharGen += 1;
			}
		}

		#endregion sov


	}

	public void CreateAT(){
		#region usat
		if (USG.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USG.text.ToString ()); i++) {
				AssaultTeam guard = new Guard ("US");
				guard.CharPanel = ATmanager.atManager.atPrefab;
				guard.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + guard.AT_ID.ToString() + " " + guard.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (guard);
				FactionManager.control.Factions ["US"].TotalGuards += 1;
			}
		}

		if (USMG.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USMG.text.ToString ()); i++) {
				AssaultTeam Mguard = new MotorGuard("US");
				Mguard.CharPanel = ATmanager.atManager.atPrefab;
				Mguard.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + Mguard.AT_ID.ToString() + " " + Mguard.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (Mguard);
				FactionManager.control.Factions ["US"].TotalMguards += 1;
			}
		}


		if (USIN.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USIN.text.ToString ()); i++) {
				AssaultTeam inf = new ATInfantry("US");
				inf.CharPanel = ATmanager.atManager.atPrefab;
				inf.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + inf.AT_ID.ToString() + " " + inf.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (inf);
				FactionManager.control.Factions ["US"].TotalInfantry += 1;
			}
		}
			
		if (USMIN.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USMIN.text.ToString ()); i++) {
				AssaultTeam Minf = new MotorizedInf("US");
				Minf.CharPanel = ATmanager.atManager.atPrefab;
				Minf.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + Minf.AT_ID.ToString() + " " + Minf.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (Minf);
				FactionManager.control.Factions ["US"].TotalMinfantry += 1;
			}
		}

		if (USMECHIN.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USMECHIN.text.ToString ()); i++) {
				AssaultTeam Mechinf = new MechInfantry("US");
				Mechinf.CharPanel = ATmanager.atManager.atPrefab;
				Mechinf.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + Mechinf.AT_ID.ToString() + " " + Mechinf.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (Mechinf);
				FactionManager.control.Factions ["US"].TotalMechInfantry += 1;
			}
		}

		if (USR.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USR.text.ToString ()); i++) {
				AssaultTeam Rec = new ATRecon("US");
				Rec.CharPanel = ATmanager.atManager.atPrefab;
				Rec.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + Rec.AT_ID.ToString() + " " + Rec.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (Rec);
				FactionManager.control.Factions ["US"].TotalRecon += 1;
			}
		}

		if (USMR.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USMR.text.ToString ()); i++) {
				AssaultTeam MRec = new MotorRecon("US");
				MRec.CharPanel = ATmanager.atManager.atPrefab;
				MRec.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + MRec.AT_ID.ToString() + " " + MRec.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (MRec);
				FactionManager.control.Factions ["US"].TotalMrecon += 1;
			}


		}
			
		if (USMECHR.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USMECHR.text.ToString ()); i++) {
				AssaultTeam MechRec = new MechRecon("US");
				MechRec.CharPanel = ATmanager.atManager.atPrefab;
				MechRec.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + MechRec.AT_ID.ToString() + " " + MechRec.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (MechRec);
				FactionManager.control.Factions ["US"].TotalMechRecon += 1;
			}
		}

		if (USLA.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USLA.text.ToString ()); i++) {
				AssaultTeam Larm = new LightArmor("US");
				Larm.CharPanel = ATmanager.atManager.atPrefab;
				Larm.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + Larm.AT_ID.ToString() + " " + Larm.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (Larm);
				FactionManager.control.Factions ["US"].TotalLightArmor += 1;
			}
		}

		if (USMA.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USMA.text.ToString ()); i++) {
				AssaultTeam Marm = new MediumArmor("US");
				Marm.CharPanel = ATmanager.atManager.atPrefab;
				Marm.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + Marm.AT_ID.ToString() + " " + Marm.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (Marm);
				FactionManager.control.Factions ["US"].TotalMediumArmor += 1;
			}
		}

		if (USDESTROY.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USDESTROY.text.ToString ()); i++) {
				AssaultTeam td = new Destroyers("US");
				td.CharPanel = ATmanager.atManager.atPrefab;
				td.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + td.AT_ID.ToString() + " " + td.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (td);
				FactionManager.control.Factions ["US"].TotalDestroyers += 1;
			}
		}

		if (USHA.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USHA.text.ToString ()); i++) {
				AssaultTeam Harm = new HeavyArmor("US");
				Harm.CharPanel = ATmanager.atManager.atPrefab;
				Harm.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + Harm.AT_ID.ToString() + " " + Harm.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (Harm);
				FactionManager.control.Factions ["US"].TotalHeavyArmor += 1;
			}
		}

		if (USPATH.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPATH.text.ToString ()); i++) {
				AssaultTeam fin = new ATPathfinder("US");
				fin.CharPanel = ATmanager.atManager.atPrefab;
				fin.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + fin.AT_ID.ToString() + " " + fin.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (fin);
				FactionManager.control.Factions ["US"].TotalPathfinders += 1;
			}
		}

		if (USPAR.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USPAR.text.ToString ()); i++) {
				AssaultTeam tro = new ParaTrooper("US");
				tro.CharPanel = ATmanager.atManager.atPrefab;
				tro.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + tro.AT_ID.ToString() + " " + tro.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (tro);
				FactionManager.control.Factions ["US"].TotalParatroopers += 1;
			}
		}

		if (USRECF.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USRECF.text.ToString ()); i++) {
				AssaultTeam onF = new ReconFighter("US");
				onF.CharPanel = ATmanager.atManager.atPrefab;
				onF.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + onF.AT_ID.ToString() + " " + onF.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (onF);
				FactionManager.control.Factions ["US"].TotalReconFighters += 1;
			}
		}

		if (USMF.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USMF.text.ToString ()); i++) {
				AssaultTeam Squ = new FighterSquadron("US");
				Squ.CharPanel = ATmanager.atManager.atPrefab;
				Squ.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + Squ.AT_ID.ToString() + " " + Squ.AT_Type.ToString();

				FactionManager.control.Factions ["US"].AssaultTeams.Add (Squ);
				FactionManager.control.Factions ["US"].TotalFighterSquadrons += 1;
			}
		}

		if (USHF.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (USHF.text.ToString ()); i++) {
				AssaultTeam ron = new HeavyFighterSquadron("US");
				ron.CharPanel = ATmanager.atManager.atPrefab;
				ron.AT_Name = FactionManager.control.Factions["US"].Tag + "-" + ron.AT_ID.ToString() + " " + ron.AT_Type.ToString();
			
				FactionManager.control.Factions ["US"].AssaultTeams.Add (ron);
				FactionManager.control.Factions ["US"].TotalHeavyFighterSquadrons += 1;
			}
		}
		#endregion usat

		#region geat
		if (GEG.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEG.text.ToString ()); i++) {
				AssaultTeam guard = new Guard ("GERMANY");
				guard.CharPanel = ATmanager.atManager.atPrefab;
				guard.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + guard.AT_ID.ToString() + " " + guard.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (guard);
				FactionManager.control.Factions ["GERMANY"].TotalGuards += 1;
			}
		}

		if (GEMG.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEMG.text.ToString ()); i++) {
				AssaultTeam Mguard = new MotorGuard("GERMANY");
				Mguard.CharPanel = ATmanager.atManager.atPrefab;
				Mguard.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + Mguard.AT_ID.ToString() + " " + Mguard.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (Mguard);
				FactionManager.control.Factions ["GERMANY"].TotalMguards += 1;
			}
		}


		if (GEIN.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEIN.text.ToString ()); i++) {
				AssaultTeam inf = new ATInfantry("GERMANY");
				inf.CharPanel = ATmanager.atManager.atPrefab;
				inf.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + inf.AT_ID.ToString() + " " + inf.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (inf);
				FactionManager.control.Factions ["GERMANY"].TotalInfantry += 1;
			}
		}

		if (GEMIN.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEMIN.text.ToString ()); i++) {
				AssaultTeam Minf = new MotorizedInf("GERMANY");
				Minf.CharPanel = ATmanager.atManager.atPrefab;
				Minf.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + Minf.AT_ID.ToString() + " " + Minf.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (Minf);
				FactionManager.control.Factions ["GERMANY"].TotalMinfantry += 1;
			}
		}

		if (GEMECHIN.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEMECHIN.text.ToString ()); i++) {
				AssaultTeam Mechinf = new MechInfantry("GERMANY");
				Mechinf.CharPanel = ATmanager.atManager.atPrefab;
				Mechinf.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + Mechinf.AT_ID.ToString() + " " + Mechinf.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (Mechinf);
				FactionManager.control.Factions ["GERMANY"].TotalMechInfantry += 1;
			}
		}

		if (GER.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GER.text.ToString ()); i++) {
				AssaultTeam Rec = new ATRecon("GERMANY");
				Rec.CharPanel = ATmanager.atManager.atPrefab;
				Rec.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + Rec.AT_ID.ToString() + " " + Rec.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (Rec);
				FactionManager.control.Factions ["GERMANY"].TotalRecon += 1;
			}
		}

		if (GEMR.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEMR.text.ToString ()); i++) {
				AssaultTeam MRec = new MotorRecon("GERMANY");
				MRec.CharPanel = ATmanager.atManager.atPrefab;
				MRec.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + MRec.AT_ID.ToString() + " " + MRec.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (MRec);
				FactionManager.control.Factions ["GERMANY"].TotalMrecon += 1;
			}


		}

		if (GEMECHR.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEMECHR.text.ToString ()); i++) {
				AssaultTeam MechRec = new MechRecon("GERMANY");
				MechRec.CharPanel = ATmanager.atManager.atPrefab;
				MechRec.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + MechRec.AT_ID.ToString() + " " + MechRec.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (MechRec);
				FactionManager.control.Factions ["GERMANY"].TotalMechRecon += 1;
			}
		}

		if (GELA.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GELA.text.ToString ()); i++) {
				AssaultTeam Larm = new LightArmor("GERMANY");
				Larm.CharPanel = ATmanager.atManager.atPrefab;
				Larm.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + Larm.AT_ID.ToString() + " " + Larm.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (Larm);
				FactionManager.control.Factions ["GERMANY"].TotalLightArmor += 1;
			}
		}

		if (GEMA.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEMA.text.ToString ()); i++) {
				AssaultTeam Marm = new MediumArmor("GERMANY");
				Marm.CharPanel = ATmanager.atManager.atPrefab;
				Marm.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + Marm.AT_ID.ToString() + " " + Marm.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (Marm);
				FactionManager.control.Factions ["GERMANY"].TotalMediumArmor += 1;
			}
		}

		if (GEDESTROY.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEDESTROY.text.ToString ()); i++) {
				AssaultTeam td = new Destroyers("GERMANY");
				td.CharPanel = ATmanager.atManager.atPrefab;
				td.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + td.AT_ID.ToString() + " " + td.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (td);
				FactionManager.control.Factions ["GERMANY"].TotalDestroyers += 1;
			}
		}

		if (GEHA.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEHA.text.ToString ()); i++) {
				AssaultTeam Harm = new HeavyArmor("GERMANY");
				Harm.CharPanel = ATmanager.atManager.atPrefab;
				Harm.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + Harm.AT_ID.ToString() + " " + Harm.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (Harm);
				FactionManager.control.Factions ["GERMANY"].TotalHeavyArmor += 1;
			}
		}

		if (GEPATH.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPATH.text.ToString ()); i++) {
				AssaultTeam fin = new ATPathfinder("GERMANY");
				fin.CharPanel = ATmanager.atManager.atPrefab;
				fin.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + fin.AT_ID.ToString() + " " + fin.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (fin);
				FactionManager.control.Factions ["GERMANY"].TotalPathfinders += 1;
			}
		}

		if (GEPAR.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEPAR.text.ToString ()); i++) {
				AssaultTeam tro = new ParaTrooper("GERMANY");
				tro.CharPanel = ATmanager.atManager.atPrefab;
				tro.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + tro.AT_ID.ToString() + " " + tro.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (tro);
				FactionManager.control.Factions ["GERMANY"].TotalParatroopers += 1;
			}
		}

		if (GERECF.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GERECF.text.ToString ()); i++) {
				AssaultTeam onF = new ReconFighter("GERMANY");
				onF.CharPanel = ATmanager.atManager.atPrefab;
				onF.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + onF.AT_ID.ToString() + " " + onF.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (onF);
				FactionManager.control.Factions ["GERMANY"].TotalReconFighters += 1;
			}
		}

		if (GEMF.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEMF.text.ToString ()); i++) {
				AssaultTeam Squ = new FighterSquadron("GERMANY");
				Squ.CharPanel = ATmanager.atManager.atPrefab;
				Squ.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + Squ.AT_ID.ToString() + " " + Squ.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (Squ);
				FactionManager.control.Factions ["GERMANY"].TotalFighterSquadrons += 1;
			}
		}

		if (GEHF.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (GEHF.text.ToString ()); i++) {
				AssaultTeam ron = new HeavyFighterSquadron("GERMANY");
				ron.CharPanel = ATmanager.atManager.atPrefab;
				ron.AT_Name = FactionManager.control.Factions["GERMANY"].Tag + "-" + ron.AT_ID.ToString() + " " + ron.AT_Type.ToString();

				FactionManager.control.Factions ["GERMANY"].AssaultTeams.Add (ron);
				FactionManager.control.Factions ["GERMANY"].TotalHeavyFighterSquadrons += 1;
			}
		}
		#endregion geat

		#region soat
		if (SOG.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOG.text.ToString ()); i++) {
				AssaultTeam guard = new Guard ("SOVIET");
				guard.CharPanel = ATmanager.atManager.atPrefab;
				guard.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + guard.AT_ID.ToString() + " " + guard.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (guard);
				FactionManager.control.Factions ["SOVIET"].TotalGuards += 1;
			}
		}

		if (SOMG.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOMG.text.ToString ()); i++) {
				AssaultTeam Mguard = new MotorGuard("SOVIET");
				Mguard.CharPanel = ATmanager.atManager.atPrefab;
				Mguard.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + Mguard.AT_ID.ToString() + " " + Mguard.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (Mguard);
				FactionManager.control.Factions ["SOVIET"].TotalMguards += 1;
			}
		}


		if (SOIN.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOIN.text.ToString ()); i++) {
				AssaultTeam inf = new ATInfantry("SOVIET");
				inf.CharPanel = ATmanager.atManager.atPrefab;
				inf.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + inf.AT_ID.ToString() + " " + inf.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (inf);
				FactionManager.control.Factions ["SOVIET"].TotalInfantry += 1;
			}
		}

		if (SOMIN.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOMIN.text.ToString ()); i++) {
				AssaultTeam Minf = new MotorizedInf("SOVIET");
				Minf.CharPanel = ATmanager.atManager.atPrefab;
				Minf.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + Minf.AT_ID.ToString() + " " + Minf.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (Minf);
				FactionManager.control.Factions ["SOVIET"].TotalMinfantry += 1;
			}
		}

		if (SOMECHIN.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOMECHIN.text.ToString ()); i++) {
				AssaultTeam Mechinf = new MechInfantry("SOVIET");
				Mechinf.CharPanel = ATmanager.atManager.atPrefab;
				Mechinf.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + Mechinf.AT_ID.ToString() + " " + Mechinf.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (Mechinf);
				FactionManager.control.Factions ["SOVIET"].TotalMechInfantry += 1;
			}
		}

		if (SOR.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOR.text.ToString ()); i++) {
				AssaultTeam Rec = new ATRecon("SOVIET");
				Rec.CharPanel = ATmanager.atManager.atPrefab;
				Rec.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + Rec.AT_ID.ToString() + " " + Rec.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (Rec);
				FactionManager.control.Factions ["SOVIET"].TotalRecon += 1;
			}
		}

		if (SOMR.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOMR.text.ToString ()); i++) {
				AssaultTeam MRec = new MotorRecon("SOVIET");
				MRec.CharPanel = ATmanager.atManager.atPrefab;
				MRec.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + MRec.AT_ID.ToString() + " " + MRec.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (MRec);
				FactionManager.control.Factions ["SOVIET"].TotalMrecon += 1;
			}


		}

		if (SOMECHR.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOMECHR.text.ToString ()); i++) {
				AssaultTeam MechRec = new MechRecon("SOVIET");
				MechRec.CharPanel = ATmanager.atManager.atPrefab;
				MechRec.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + MechRec.AT_ID.ToString() + " " + MechRec.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (MechRec);
				FactionManager.control.Factions ["SOVIET"].TotalMechRecon += 1;
			}
		}

		if (SOLA.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOLA.text.ToString ()); i++) {
				AssaultTeam Larm = new LightArmor("SOVIET");
				Larm.CharPanel = ATmanager.atManager.atPrefab;
				Larm.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + Larm.AT_ID.ToString() + " " + Larm.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (Larm);
				FactionManager.control.Factions ["SOVIET"].TotalLightArmor += 1;
			}
		}

		if (SOMA.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOMA.text.ToString ()); i++) {
				AssaultTeam Marm = new MediumArmor("SOVIET");
				Marm.CharPanel = ATmanager.atManager.atPrefab;
				Marm.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + Marm.AT_ID.ToString() + " " + Marm.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (Marm);
				FactionManager.control.Factions ["SOVIET"].TotalMediumArmor += 1;
			}
		}

		if (SODESTROY.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SODESTROY.text.ToString ()); i++) {
				AssaultTeam td = new Destroyers("SOVIET");
				td.CharPanel = ATmanager.atManager.atPrefab;
				td.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + td.AT_ID.ToString() + " " + td.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (td);
				FactionManager.control.Factions ["SOVIET"].TotalDestroyers += 1;
			}
		}

		if (SOHA.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOHA.text.ToString ()); i++) {
				AssaultTeam Harm = new HeavyArmor("SOVIET");
				Harm.CharPanel = ATmanager.atManager.atPrefab;
				Harm.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + Harm.AT_ID.ToString() + " " + Harm.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (Harm);
				FactionManager.control.Factions ["SOVIET"].TotalHeavyArmor += 1;
			}
		}

		if (SOPATH.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPATH.text.ToString ()); i++) {
				AssaultTeam fin = new ATPathfinder("SOVIET");
				fin.CharPanel = ATmanager.atManager.atPrefab;
				fin.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + fin.AT_ID.ToString() + " " + fin.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (fin);
				FactionManager.control.Factions ["SOVIET"].TotalPathfinders += 1;
			}
		}

		if (SOPAR.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOPAR.text.ToString ()); i++) {
				AssaultTeam tro = new ParaTrooper("SOVIET");
				tro.CharPanel = ATmanager.atManager.atPrefab;
				tro.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + tro.AT_ID.ToString() + " " + tro.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (tro);
				FactionManager.control.Factions ["SOVIET"].TotalParatroopers += 1;
			}
		}

		if (SORECF.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SORECF.text.ToString ()); i++) {
				AssaultTeam onF = new ReconFighter("SOVIET");
				onF.CharPanel = ATmanager.atManager.atPrefab;
				onF.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + onF.AT_ID.ToString() + " " + onF.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (onF);
				FactionManager.control.Factions ["SOVIET"].TotalReconFighters += 1;
			}
		}

		if (SOMF.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOMF.text.ToString ()); i++) {
				AssaultTeam Squ = new FighterSquadron("SOVIET");
				Squ.CharPanel = ATmanager.atManager.atPrefab;
				Squ.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + Squ.AT_ID.ToString() + " " + Squ.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (Squ);
				FactionManager.control.Factions ["SOVIET"].TotalFighterSquadrons += 1;
			}
		}

		if (SOHF.text.ToString () == "") {
			//////Debug.LogError ("no text");
		} else {
			for (int i = 0; i < int.Parse (SOHF.text.ToString ()); i++) {
				AssaultTeam ron = new HeavyFighterSquadron("SOVIET");
				ron.CharPanel = ATmanager.atManager.atPrefab;
				ron.AT_Name = FactionManager.control.Factions["SOVIET"].Tag + "-" + ron.AT_ID.ToString() + " " + ron.AT_Type.ToString();

				FactionManager.control.Factions ["SOVIET"].AssaultTeams.Add (ron);
				FactionManager.control.Factions ["SOVIET"].TotalHeavyFighterSquadrons += 1;
			}
		}
		#endregion soat

	}

	#endregion create

	void Awake(){
		// only one instance allowed
		if (FirstTimeRun == null) {
			//DontDestroyOnLoad (gameObject);
			FirstTimeRun = this;
		} else if (FirstTimeRun != this) {
			Destroy (gameObject);
		}
		//GCref.IsFirstTimeRun = true;
	}
	// SOVIETe this for initialization
	void Start () {
		GetFTR ();
		//GCref.SetATData ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// flow

	// collect infantry data
	public void Begin(){
		
		if(string.IsNullOrEmpty(warCounter.text) || string.IsNullOrEmpty(warfunds.text) || string.IsNullOrEmpty(gold.text) || string.IsNullOrEmpty(inGameName.text) || string.IsNullOrEmpty(preferedFaction.captionText.text))
		//if (warCounter.text credits.text == "" || warfunds.text == "" || gold.text == "" || inGameName.text == "" || preferedFaction.captionText.text == "") 
		{
			Debug.LogError ("Begin(): not all fields filled in....");
			return;
		} else {
			GCref.warCount = int.Parse (warCounter.text);
			GCref.Credits = int.Parse (credits.text);
			GCref.Warfunds = int.Parse (warfunds.text);
			GCref.Gold = int.Parse (gold.text);
			if (clanName.text == "") {
				GCref.clanName = null;
			} else {
				GCref.clanName = clanName.text;
			}

			GCref.inGameName = inGameName.text;
			GCref.CurrentFaction = preferedFaction.captionText.text;

			Startcollecting ();
		}
		GetFTR ();
	}

	void Startcollecting(){
		begin.SetActive (false);
		infpanel.SetActive (true);
		us.SetActive (true);
		ge.SetActive (true);
		so.SetActive (true);
	}
}