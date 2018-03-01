using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour {

	public GameObject sliderPrefab;

	public void CreateBar(ParseData.Result result)
	{
		GameObject currentSlider = Instantiate(sliderPrefab, this.transform, false);
		currentSlider.GetComponent<Slider>().value = result.passed;
		currentSlider.GetComponentInChildren<Image>().color = Color.green;
	}
}
