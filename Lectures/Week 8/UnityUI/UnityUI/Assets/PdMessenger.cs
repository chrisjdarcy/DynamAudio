using UnityEngine;
using System.Collections;
using LibPDBinding;
using UnityEngine.UI;

public class PdMessenger : MonoBehaviour {

  
//	public float fToggleValue;
	public float fThunder;
	public float fRain;
	public float fWind;
	public float fFire;


		
	public void SendThunderValue(bool toggleThunder){

		if (toggleThunder == true) { 

			fThunder = 1f;
		} else {
			fThunder = 0f;
		}

			Debug.Log (fThunder);

		LibPD.SendFloat ("thunderToggle", fThunder);


	}

	public void SendRainValue(bool toggleRain){

		if (toggleRain == true) { 

			fRain = 1f;
		} else {
			fRain = 0f;
		}

		Debug.Log (fRain);

		LibPD.SendFloat ("rainToggle", fRain);


	}

	public void SendWindValue(bool toggleWind){

		if (toggleWind == true) { 

			fWind = 1f;
		} else {
			fWind = 0f;
		}

		Debug.Log (fWind);

		LibPD.SendFloat ("windToggle", fWind);


	}




	public void SendFireValue(bool toggleFire){

		if (toggleFire == true) { 

			fFire = 1f;
		} else {
			fFire = 0f;
		}

		Debug.Log (fFire);

		LibPD.SendFloat ("fireToggle", fFire);


}

/*
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
*/
		
	}

