using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public GameObject player;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 distance = transform.position - player.transform.position;
        
        if(distance.magnitude < 3)
        {
            transform.position += (-distance * speed * Time.deltaTime)/distance.magnitude;
            Debug.Log(Time.deltaTime);
        }
	}
}
