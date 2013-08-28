using UnityEngine;
using System.Collections;

public class WallController : MonoBehaviour {
	
	bool doneChange = false;
	
	void FixedUpdate(){
		doneChange = false;
	}

	void OnCollisionEnter(Collision coll){
		if(coll.gameObject.layer == LayerMask.NameToLayer("invader") && ! doneChange){
			InvaderGroupController.ChangeDirection();
			doneChange = true;
		}
	}
	
}
