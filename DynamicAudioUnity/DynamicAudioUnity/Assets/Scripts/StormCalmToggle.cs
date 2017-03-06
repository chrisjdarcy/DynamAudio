using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Toggle))]
public class StormCalmToggle: MonoBehaviour {

	public Toggle toggle1;
	public Toggle toggle2;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
			toggle2.isOn = !toggle1.isOn;
		}
		

}
