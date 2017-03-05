using UnityEngine;
using UnityEngine.UI;
using System.Collections;


[RequireComponent (typeof(Slider))]
public class SliderLerp : MonoBehaviour {

	public Slider slider;
	public float targetSliderValue;
	public Toggle toggle;
	public float deltaSeconds;
	public float time = 0.0f;
		// Use this for initialization
	void Start () {
		deltaSeconds = Time.deltaTime;
	}

	// Update is called once per frame
	void Update () {
		//Checks if slider is at max value
		if (slider.value == targetSliderValue) {
		} else if (slider.value >= 0.999f) {
			slider.value = 1.0f;
		} 

		//If toggle is on
		else if (toggle.isOn == true) { 
			//Lerps slider to target value
			slider.value = Mathf.Lerp (slider.value, targetSliderValue, deltaSeconds); 	
		}

		//Checks if slider is at zero
		if (slider.value == 0.0f) {
		}
		else if (slider.value <= 0.001f) {
			slider.value = 0.0f;
		}
		else if (toggle.isOn == false) { 
			//Lerps slider to zero
			slider.value = Mathf.Lerp (slider.value, 0.0f, deltaSeconds); 	
	}
}
}