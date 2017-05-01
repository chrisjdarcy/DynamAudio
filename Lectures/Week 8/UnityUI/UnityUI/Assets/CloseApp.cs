using UnityEngine;
using System.Collections;
using LibPDBinding;
using UnityEngine.UI;

public class CloseApp : MonoBehaviour {


	public void Update() {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit();
		}
	}
}