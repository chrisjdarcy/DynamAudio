using UnityEngine;
using System.Collections;
using LibPDBinding;
using UnityEngine.UI;

public class PdMessenger : MonoBehaviour {

	public float thunderToggleValue;
	public float rainToggleValue;
	public float windToggleValue;
	public float fireToggleValue;

	public void SendThunderValue(bool thunder){

		if (thunder) { 

			thunderToggleValue = 1f;
		} else {
			thunderToggleValue = 0f;
		}

		Debug.Log (thunderToggleValue);

		LibPD.SendFloat ("ThunderToggle", thunderToggleValue);


	}

		

	public void SendRainValue(bool rain){

		if (rain) { 

			rainToggleValue = 1f;
		} else {
			rainToggleValue = 0f;
		}

		Debug.Log (rainToggleValue);

		LibPD.SendFloat ("RainToggle", rainToggleValue);


	}

	public void SendWindValue(bool wind){

		if (wind) { 

			windToggleValue = 1f;
		} else {
			windToggleValue = 0f;
		}

		Debug.Log (windToggleValue);

		LibPD.SendFloat ("WindToggle", windToggleValue);


	}

	public void SendFireValue(bool fire){

		if (fire) { 

			fireToggleValue = 1f;
		} else {
			fireToggleValue = 0f;
		}

		Debug.Log (fireToggleValue);

		LibPD.SendFloat ("FireToggle", fireToggleValue);


	}

}
