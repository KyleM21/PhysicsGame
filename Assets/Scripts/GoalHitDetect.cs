using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalHitDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter2D(Collider2D Object){
		if(Object.gameObject.tag == "Player"){
			Debug.Log("Goal Met");
		}
	}
		
}
