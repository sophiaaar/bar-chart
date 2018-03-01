using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerticalAxis : MonoBehaviour {
	public GameObject axisLabel;

	public void CreateAxis(ParseData.Result result)
	{
		GameObject label = GameObject.Instantiate(axisLabel, this.transform, false);
		//Debug.Log(label);
		label.GetComponent<Text>().text = result.milestoneName;
		//Debug.Log(label.GetComponent<Text>().text);

	}
}
