using UnityEngine;
using System.Collections;

public class dance : MonoBehaviour {

    Rigidbody rbody;
    Vector3 inputVector;
    // Use this for initialization
    
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Time.time > 1f && Time.time < 2f)
        {
            transform.position += new Vector3(1f, 0f, Random.Range(1,4));
        }
        if (Time.time > 2f && Time.time < 3f)
        {
            transform.position += new Vector3(-1f, 0f, Random.Range(-1, -4));
        }
        if (Time.time > 3f && Time.time < 4f)
        {
            transform.position += new Vector3(0f, 0f, 1f);
        }
        if (Time.time > 5f && Time.time < 6f)
        {
            transform.position += new Vector3(1f, 0f, 0f);
        }

        if (Time.time > 6 && Time.time < 7)
        {
            transform.position += new Vector3 (-1f, 0f, 0f) ;
        }
     
    }

            

        
    }



    
