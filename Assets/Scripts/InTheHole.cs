using UnityEngine;
using System.Collections;

public class InTheHole : MonoBehaviour {

    public Collider m_ground;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        Physics.IgnoreCollision(other.GetComponent<Collider>(), m_ground);
    }
}
