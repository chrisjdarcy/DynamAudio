using UnityEngine;
using System.Collections;
using LibPDBinding;

public class GUIToggleScript : MonoBehaviour {

	bool pdToggleEngine = false;
	bool pdToggleAmmo = false;
	bool pdToggleEnvironment = false;
	bool pdToggleWind = false;
	bool pdToggleMusic = false;

	void OnGUI() {
		
		pdToggleEngine = GUI.Toggle (new Rect (10, 10, 200, 20), pdToggleEngine, " Tank Engine");

		pdToggleAmmo = GUI.Toggle(new Rect(10, 30, 200, 20), pdToggleAmmo, " Explosions / Rockets / Aiming");

		pdToggleEnvironment = GUI.Toggle(new Rect(10, 50, 200, 20), pdToggleEnvironment, " Environment");

		pdToggleWind = GUI.Toggle(new Rect(10, 70, 200, 20), pdToggleWind, " Wind");

		pdToggleMusic = GUI.Toggle(new Rect(10, 90, 200, 20), pdToggleMusic, " Music");



		if (pdToggleEngine)
			LibPD.SendFloat ("pdToggleEngine", 1);
		else
			LibPD.SendFloat ("pdToggleEngine", 0);
	

		if(pdToggleAmmo) 
			LibPD.SendFloat("pdToggleAmmo", 1);
		else
			LibPD.SendFloat("pdToggleAmmo", 0);

		if(pdToggleEnvironment) 
			LibPD.SendFloat("pdToggleEnvironment", 1);
		else
			LibPD.SendFloat("pdToggleEnvironment", 0);

		if(pdToggleWind) 
			LibPD.SendFloat("pdToggleWind", 1);
		else
			LibPD.SendFloat("pdToggleWind", 0);

		if(pdToggleMusic) 
			LibPD.SendFloat("pdToggleMusic", 1);
		else
			LibPD.SendFloat("pdToggleMusic", 0);
	}
}
