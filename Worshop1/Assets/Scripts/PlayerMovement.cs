using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Use this for initialization
    public float speed;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");
        //Debug.Log("This is V" + v);
        //Debug.Log("This is H" + h);
        //Debug.Log(transform.forward + "  " + transform.right);

        transform.position = transform.position + transform.forward * v * Time.deltaTime * speed;
        transform.position = transform.position + transform.right * h * Time.deltaTime * speed;

    }
}
