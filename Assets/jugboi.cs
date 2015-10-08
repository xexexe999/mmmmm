using UnityEngine;
using System.Collections;

public class jugboi : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter (Collider activator) {
        Destroy ( activator.gameObject );
	}
}
