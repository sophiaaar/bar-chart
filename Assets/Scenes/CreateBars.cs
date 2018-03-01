using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBars : MonoBehaviour {

	//public string[] milestones;
	//public Object dataFile;
	//public GameObject slider;
	public GameObject bar;
	public Transform chartArea;

	private float widthOfBars;
	private List<float> barPositions;
	public ParseData _parseData;

	// Use this for initialization
	void Start ()
	{
		List<ParseData.Result> listOfResults = new List<ParseData.Result>();
		listOfResults = _parseData.OrganiseData();


		if (listOfResults.Count != 0)
		{
			//RectTransform rt = chartArea.GetComponent<RectTransform>();
			//widthOfBars = rt.rect.height / listOfResults.Count;

			for (int i = 0; i < listOfResults.Count; i++)
			{
				GameObject barClone = Instantiate(bar, chartArea.transform, false);
				Bar currentBar = barClone.GetComponent<Bar>();
				currentBar.CreateBar(listOfResults[i]);
			}
			//bar.SetActive(false);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
