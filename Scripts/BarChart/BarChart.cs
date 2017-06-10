using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarChart : MonoBehaviour {
	public static BarChart BAR;
	// Barholder that holds the bar
	public BarHolder BarPrefab; 
	// values comming from user input costs, earnings,.......
	public List<int> inputValues = new List<int>();
	// Bar labels
	public List<string> labels = new List<string>();
	// colors
	public List<Color> colors = new List<Color>();
	// list to store the bars
	List<BarHolder> bars = new List<BarHolder>();
	// chartHeight needed to calculate the barHeights
	public RectTransform chartobj;
	float chartHeight;

	public float normval = 0.4f;

	//public List<inputData> data = new List<inputData> ();

	void Awake(){
		if (BAR == null) {
			DontDestroyOnLoad (gameObject);
			BAR = this;
		} else if (BAR != this) {
			Destroy (gameObject);
		}

	}

	// Use this for initialization
	void Start () {
		// get screen height and chartheight
		chartHeight = Screen.height + chartobj.sizeDelta.y - 80f;
		Debug.Log (chartHeight + " : " + chartobj.sizeDelta.y);
//		for(int i = 0; i < 8; i++){
//			inputData t = new inputData ();
//			t.label = "TST_" + i;
//			t.value = (i + 1) * 1000 ;
//			t.color = Color.blue;
//			data.Add (t);
//			inputValues.Add(t.value);
//			labels.Add(t.label);
//			colors.Add(t.color);
//		}

		// Display the graph
		//DisplayGraph(inputValues);

	}
	
	public void DisplayGraph(List<int> vals){
		ATmanager.atManager.ResetPanel (chartobj);
		// get the maximum value
		int maxValue = vals.Max();
		// adding the bar
		for (int i = 0; i < vals.Count; i++) {
			// create a new bar
			BarHolder newbar = Instantiate (BarPrefab) as BarHolder;
			// set to parent
			newbar.transform.SetParent(transform);
			// Get the recttransform component
			RectTransform rt = newbar.Bar.GetComponent<RectTransform> ();
			// divide the vals with the maxValue
			float normalizedValue = ((float)vals [i] / (float)maxValue * normval);
			// set size of the bar
			rt.sizeDelta = new Vector2(rt.sizeDelta.x, chartHeight * normalizedValue);


			// set colors
			newbar.Bar.color = colors[i % colors.Count];
			// set labels
			if (labels.Count <= i) {
				newbar.BarLabel.text = "UNDEFINED";
			}else{
				newbar.BarLabel.text = labels [i];
			}
			// set value text
			newbar.BarValue.text = vals [i].ToString();
			// if height to small, move label to top of bar
			if(rt.sizeDelta.y < 30f){
				newbar.BarValue.GetComponent<RectTransform> ().pivot = new Vector2 (0.5f, 0f);
				newbar.BarValue.GetComponent<RectTransform> ().anchoredPosition = Vector2.zero;

			}

			 
		}
	}


}

public class inputData {
	public string label;
	public int value;
	public Color color;
}