using UnityEngine;
using System.Collections;
using LibPDBinding;
public class objectLocation : MonoBehaviour {
	public Camera camera;
	public Vector3 screenPoint;
	public Vector3 scaledPoint;

	
	void Update () {
		screenPoint = camera.WorldToScreenPoint (gameObject.transform.position);
		scaledPoint.x = screenPoint.x / Screen.width;
		scaledPoint.y = screenPoint.y / Screen.height;
		LibPD.SendFloat ("freq", scaledPoint.x);
	}
}
