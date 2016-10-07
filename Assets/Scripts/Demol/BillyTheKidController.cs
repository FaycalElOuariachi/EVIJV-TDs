using UnityEngine;
using System.Collections;

public class BillyTheKidController : MonoBehaviour {

	private Rigidbody m_rb;
	private float m_min = 10;
	private float m_max = 50;
	private float m_last_z;

	// Use this for initialization
	void Start () {
		m_rb = GetComponent<Rigidbody> ();
		m_last_z = gameObject.transform.position.z;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (m_last_z > gameObject.transform.position.z) {
			// gameObject.transform.Translate (Random.Range (m_min, m_max) * Time.deltaTime, Random.Range (m_min, m_max) * Time.deltaTime, Random.Range (m_min, m_max) * Time.deltaTime);
			m_rb.AddForce (Random.Range (m_min, m_max) * Mathf.Sign(gameObject.transform.forward.x), 0, 0);
		}

		m_last_z = gameObject.transform.position.z;
	}
}
