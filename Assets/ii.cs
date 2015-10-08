using UnityEngine;
using System.Collections;

public class ii : MonoBehaviour {
  
    public Transform followThis;

Rigidbody rbody;
Vector3 inputVector;
	// Use this for initialization
	void Start () {
    rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
    // b-a if u want vectgor going from a to b)
    inputVector = followThis.position - transform.position;

	}
void FixedUpdate () {
    rbody.velocity = inputVector;
}

}
