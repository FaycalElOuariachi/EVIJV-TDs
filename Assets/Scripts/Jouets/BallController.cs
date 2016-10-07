using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    public int speed = 2;
    public int m_PlayerNumber;

    private Rigidbody m_Rigidbody;

	// Use this for initialization
	void Start () {
        m_Rigidbody = GetComponent<Rigidbody> ();
    }
	
	// Update is called once per frame
	void Update () {
        KeyboardMovements();
	}

    void KeyboardMovements()
    {
        m_Rigidbody.AddForce(Input.GetAxis("Horizontal" + m_PlayerNumber) * speed * Vector3.right);
        m_Rigidbody.AddForce(Input.GetAxis("Vertical" + m_PlayerNumber) * speed * Vector3.forward);
    }

	void OnTriggerEnter(Collider other) {

	}
}
