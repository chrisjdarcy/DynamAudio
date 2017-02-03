using UnityEngine;
using System.Collections;
using LibPDBinding;

public class PdDistance : MonoBehaviour {


	public GameObject soundsource;
	public float distance;


	
	// Update is called once per frame
	void Update () {
	

		distance = Vector3.Distance (soundsource.transform.position, transform.position);

		LibPD.SendFloat ("distance", distance);

	}
}
