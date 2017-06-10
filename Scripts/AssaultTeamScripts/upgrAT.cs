using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgrAT : MonoBehaviour {
	public Text _Name;
	public RawImage _icon;
	public InputField _rename;
	public Button _edit;
	public Text btnWFTxt;
	public Text btnGLDTxt;
	public Button wf;
	public Button gld;
	//public Toggle tgl;
	public Dropdown upgrade;
	public Button lvlup;
	public Text lvltxt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (upgrade.captionText.text == "Infantry") {
			btnWFTxt.text = CostAndPrices.CAP.UgradeToMotorInfantryWF.ToString();
			btnGLDTxt.text =  CostAndPrices.CAP.UgradeToMotorInfantryGold.ToString();
		}else if (upgrade.captionText.text == "Motorized_Guard") {
			btnWFTxt.text = CostAndPrices.CAP.UpgradeToMotorGuardWF.ToString();
			btnGLDTxt.text =  CostAndPrices.CAP.UgradeToMotorGuardGold.ToString();
		}else if (upgrade.captionText.text == "Motorized_Infantry") {
			btnWFTxt.text = CostAndPrices.CAP.UgradeToMotorInfantryWF.ToString();
			btnGLDTxt.text =  CostAndPrices.CAP.UgradeToMotorInfantryGold.ToString();
		}else if (upgrade.captionText.text == "Mechanized_Infantry") {
			btnWFTxt.text = CostAndPrices.CAP.UgradeToMechInfantryWF.ToString();
			btnGLDTxt.text =  CostAndPrices.CAP.UgradeToMechInfantryGold.ToString();
		}else if (upgrade.captionText.text == "Motorized_Recon") {
			btnWFTxt.text = CostAndPrices.CAP.UgradeToMotorReconWarfunds.ToString();
			btnGLDTxt.text =  CostAndPrices.CAP.UgradeToMotorReconGold.ToString();
		}else if (upgrade.captionText.text == "Mechanized_Recon") {
			btnWFTxt.text = CostAndPrices.CAP.UgradeToMechReconWarfunds.ToString();
			btnGLDTxt.text =  CostAndPrices.CAP.UgradeToMechReconGold.ToString();
		}else if (upgrade.captionText.text == "Medium_Armor") {
			btnWFTxt.text = CostAndPrices.CAP.UgradeToMediumArmorWF.ToString();
			btnGLDTxt.text =  CostAndPrices.CAP.UgradeToMediumArmorGold.ToString();
		}else if (upgrade.captionText.text == "MediumTankDestroyer") {
			btnWFTxt.text = CostAndPrices.CAP.UgradeToTankDestroyerWF.ToString();
			btnGLDTxt.text =  CostAndPrices.CAP.UgradeToTankDestroyerGold.ToString();
		}else if (upgrade.captionText.text == "Heavy_Armor") {
			btnWFTxt.text = CostAndPrices.CAP.UgradeToHeavyArmorWF.ToString();
			btnGLDTxt.text =  CostAndPrices.CAP.UgradeToHeavyArmorGold.ToString();
		}else if (upgrade.captionText.text == "Paratroopers") {
			btnWFTxt.text = CostAndPrices.CAP.UgradeToParatrooperWF.ToString();
			btnGLDTxt.text =  CostAndPrices.CAP.UgradeToParatrooperGold.ToString();
		}else if (upgrade.captionText.text == "Fighter_Squadron") {
			btnWFTxt.text = CostAndPrices.CAP.UgradeToMediumFightersWarfunds.ToString();
			btnGLDTxt.text =  CostAndPrices.CAP.UgradeToMediumFighterGold.ToString();
		}else if (upgrade.captionText.text == "Heavy_Fighter") {
			btnWFTxt.text = CostAndPrices.CAP.UgradeToHeavyFighterWarfunds.ToString();
			btnGLDTxt.text =  CostAndPrices.CAP.UgradeToHeavyFighterGold.ToString();
		}
	}
}
