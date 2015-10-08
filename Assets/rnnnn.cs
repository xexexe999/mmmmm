using UnityEngine;
using System.Collections;

public class rnnnn : MonoBehaviour {
    public float moveSpeed = 5f;
    Rigidbody rbody;
    Vector2 inputVector;
    // Use this for initialization
 
	void Start () {
        rbody = GetComponent<Rigidbody>();
	}
	void Update ()
    {


        inputVector = new Vector2 (Input.GetAxis ( "Mouse X" ), Input.GetAxis ( "Mouse Y" ));
      
    }


	// Update is for graphics and input whereas FIXEUPDATE is for physica
	void    FixedUpdate () {
        
        rbody.velocity = transform.TransformDirection( new Vector3(inputVector.x, 0f, inputVector.y)) * moveSpeed;
        
	}
}
