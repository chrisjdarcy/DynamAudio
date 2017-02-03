using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using LibPDBinding;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	public Text countText;
	public Text winText;
	private int count;
	public float playerSpeed;


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

		playerSpeed = rb.velocity.magnitude;

		LibPD.SendFloat("playerSpeed", playerSpeed);

	
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag("Pick Up"))
			{
			other.gameObject.SetActive (false);
			count = count + 1;

			LibPD.SendFloat ("note", count);

			Debug.Log (count);
			SetCountText ();

			}
}

	void SetCountText(){

		countText.text = "Count: " + count.ToString ();
		if (count>=12)
		{
		
			winText.text = "You Win!";

		}
}
}