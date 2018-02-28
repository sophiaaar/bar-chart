using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour {

	public GameObject sliderPrefab;

	public void CreateBar(ParseData.Result result)
	{
		Instantiate(sliderPrefab, this.transform, false);

	}
}
