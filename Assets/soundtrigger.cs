using UnityEngine;
using System.Collections;

public class ssssssss : MonoBehaviour {
    public AudioSource mySound;


	
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            mySound.Play();
	}
    void OnTriggerEnter()
    {
        mySound.Play();
    }
}
