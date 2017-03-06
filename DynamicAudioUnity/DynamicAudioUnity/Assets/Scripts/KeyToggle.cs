using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Toggle))]
public class KeyToggle : MonoBehaviour {

	public KeyCode key;
	public Toggle toggle;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (key)) {
			toggle.isOn = !toggle.isOn;
		}
		}
}
