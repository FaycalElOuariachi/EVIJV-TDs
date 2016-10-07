using UnityEngine;
using System.Collections;

public class BulbyController : MonoBehaviour {

	public float speed = 0.02f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		KeyboardMovements();
	}

	void KeyboardMovements()
	{
		gameObject.transform.Translate (Input.GetAxis("Horizontal1") * speed * Vector3.right + 
			Input.GetAxis("Vertical1") * speed * Vector3.forward);

		Debug.Log (Input.GetAxis("Horizontal2"));
		gameObject.transform.Rotate (Input.GetAxis("Horizontal2") * speed*10 * Vector3.right + 
			Input.GetAxis("Vertical2") * speed*10 * Vector3.forward);
		
	}
}
