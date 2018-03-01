using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour {

	public GameObject sliderPrefab;

	public void CreateBar(ParseData.Result result)
	{
		GameObject blockedSlider = Instantiate(sliderPrefab, this.transform, false);
		blockedSlider.GetComponent<Slider>().value = result.passed + result.failed + result.blocked; //this one should render behind the failed slider, so only the failed amount should poke out
		blockedSlider.GetComponentInChildren<Image>().color = Color.grey;
		//Debug.Log("blocked " + blockedSlider.GetComponent<Slider>().value);

		GameObject failedSlider = Instantiate(sliderPrefab, this.transform, false);
		failedSlider.GetComponent<Slider>().value = result.passed + result.failed; //this one should render behind the passed slider, so only the failed amount should poke out
		failedSlider.GetComponentInChildren<Image>().color = Color.red;
		//Debug.Log("failed " + failedSlider.GetComponent<Slider>().value);

		GameObject passedSlider = Instantiate(sliderPrefab, this.transform, false);
		passedSlider.GetComponent<Slider>().value = result.passed;
		passedSlider.GetComponentInChildren<Image>().color = Color.green;
		//Debug.Log("passed " + passedSlider.GetComponent<Slider>().value);

		
	}
}
