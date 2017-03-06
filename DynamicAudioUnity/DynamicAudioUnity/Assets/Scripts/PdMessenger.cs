using UnityEngine;
using System.Collections;
using LibPDBinding;
using UnityEngine.UI;

public class PdMessenger : MonoBehaviour {

  
	float playToggleValue;
	float stormToggleValue;


	public void SendMusicValue(float musicValue){

		LibPD.SendFloat ("MusicLevel", musicValue);


	}

	public void SendWindValue(float windValue){

		LibPD.SendFloat ("WindLevel", windValue);


	}
	public void SendThunderValue(float thunderValue){

		LibPD.SendFloat ("ThunderLevel", thunderValue);


	}
	public void SendRainValue(float rainValue){

		LibPD.SendFloat ("RainLevel", rainValue);


	}
	public void SendShoreValue(float shoreValue){

		LibPD.SendFloat ("ShoreLevel", shoreValue);


	}
	public void SendFireValue(float fireValue){

		LibPD.SendFloat ("FireLevel", fireValue);


	}


	public void SendPlayValue(bool play){

		if (play) { 

			playToggleValue = 1f;
		} else {
			playToggleValue = 0f;
		}

		Debug.Log (playToggleValue);

		LibPD.SendFloat ("Play", playToggleValue);


	}

		

	public void SendStormValue(bool storm){

		if (storm) { 

			stormToggleValue = 1f;
		} else {
			stormToggleValue = 0f;
		}

		Debug.Log (playToggleValue);

		LibPD.SendFloat ("StormToggle", stormToggleValue);


	}

}
