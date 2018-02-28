using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ParseData : MonoBehaviour {

	//public object dataFile;

	public struct Result
	{
		public string milestoneName;
		public int passed;
		public int failed;
		public int blocked;
	}

	// Use this for initialization
	void Start () {
		OrganiseData();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public List<Result> OrganiseData()
	{
		List<string> listOfLines = new List<string>();
		List<Result> listOfResult = new List<Result>();
		int counter = 0;  
		string line;

		StreamReader file = new StreamReader(@"Assets/data.csv"); 
		// go through each line and put each line into list
		while((line = file.ReadLine()) != null)  
		{  
			//Debug.Log(line);
			listOfLines.Add(line);  
			counter++;  
		}

		for (int i = 0; i < listOfLines.Count; i++)
		{
			// separate each line by the commas
			string[] values = listOfLines[i].Split(',');
			// each line is a new Result
			Result result;
			result.milestoneName = values[0];
			result.passed = int.Parse(values[1]);
			result.failed = int.Parse(values[2]);
			result.blocked = int.Parse(values[3]);
			listOfResult.Add(result);
		}

		//Debug.Log("There were " + counter + " lines");
		
		return listOfResult;
	}
}
