using UnityEngine;
using System.Collections;

public class CursorTransform : MonoBehaviour {

	public Vector3 cursor;
	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;


	// Use this for initialization
	void Start () {
		cursor = transform.position;
		cursor.x = Mathf.Clamp(transform.position.x, xMin, xMax);
		cursor.y = Mathf.Clamp(transform.position.y, yMin, yMax);
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
