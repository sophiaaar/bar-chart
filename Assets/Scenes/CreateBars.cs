using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBars : MonoBehaviour {

	public string[] milestones;
	public Object dataFile;
	public GameObject barSprite;
	public Transform chartArea;

	private float widthOfBars;
	private List<float> barPositions;

	// Use this for initialization
	void Start ()
	{		
		if (milestones.Length != 0)
		{
			RectTransform rt = chartArea.GetComponent<RectTransform>();
			//Debug.Log("height " + rt.rect.height);
			widthOfBars = rt.rect.height / milestones.Length;
			//barSprite.transform.localScale = ChangeBarHeight();

			RectTransform rt2 = barSprite.GetComponent<RectTransform>();
			rt2.sizeDelta = new Vector2(1f, widthOfBars);
			//Debug.Log("bar width " + widthOfBars);
			//barPositions = new List<float>();
			for (int i = 0; i < milestones.Length; i++)
			{
				float barPos = (widthOfBars * i) - (rt.rect.height / 2.5f); // diving the height by 2 puts the bottom bar right on the edge
				//Debug.Log("barpos " + barPos);
				

				GameObject barClone = Instantiate(barSprite, new Vector3(barSprite.transform.position.x, barPos, 1), Quaternion.identity);
				//barClone.transform.parent = chartArea.parent;
				//float barHeight = barClone.GetComponent<RectTransform>().localScale.y;
				//barHeight = widthOfBars;
			}
			barSprite.SetActive(false);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	Vector3 ChangeBarHeight()
	{
		float spriteHeight = barSprite.transform.localScale.y;
		spriteHeight = widthOfBars;
		//Debug.Log(barSprite.transform.localScale.y);

		Vector3 scale = new Vector3(10f, spriteHeight, 1f);

		// RectTransform rt = barSprite.GetComponent<RectTransform>();
		// rt.sizeDelta = new Vector2(10f, spriteHeight);
		return scale;
	}
}
