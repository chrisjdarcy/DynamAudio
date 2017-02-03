using UnityEngine; 
using System.Collections;
using LibPDBinding; // Using the LibPd library

public class PdSendValues : MonoBehaviour {


	public float x; // Initialising a public float variable called 'x'. This will store the cube's x position

	public float y; // Initialising a public float variable called 'y'. This will store the cube's y position

	
	// Update is called once per frame
	void Update () {

		x = transform.position.x; // Once per frame we update the value stored in 'x' with the new x,y positions of the cube.
		y = transform.position.y;


		//Here we send to pure data those values:

		LibPD.SendFloat("frequency", x); 
		LibPD.SendFloat("amplitude", y);


		/* We're accessing the SendFloat function within the LibPd library. We do this by typing first LibPd then "." 
		and then the name of the function, in this case "SendFloat". Then, within the parenthesis, the first argument is the 
		name of the receive within Pure Data (in this case "frequency" and "amplitude") and then the float we want to send there,
		in this case x and y, which are storing the cube's x and y positions */ 

	
	}
}
	
