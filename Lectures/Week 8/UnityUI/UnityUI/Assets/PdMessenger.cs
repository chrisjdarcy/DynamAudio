using UnityEngine;
using System.Collections;
using LibPDBinding;
using UnityEngine.UI;

public class PdMessenger : MonoBehaviour {

  
	public float fToggleValue;



	public void SendSliderValue(float slideValue){

		LibPD.SendFloat ("SliderValue", slideValue);


	}
		
	public void Sendhello(float hello){

		LibPD.SendFloat ("Hello", hello);


	}

	public void SendToggleValue(bool toggleValue){

		if (toggleValue) { 

			fToggleValue = 1f;
		} else {
			fToggleValue = 0f;
		}

		Debug.Log (fToggleValue);

		LibPD.SendFloat ("ToggleValue", fToggleValue);


	}

		

}
