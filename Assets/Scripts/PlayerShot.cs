using UnityEngine;
using System.Collections;

public class PlayerShot : MonoBehaviour {
	
	public float speed = 10.0f;
	
	public static int maxShots = 3;
	public static int numberShots = 0;
	
	void FixedUpdate () {
		rigidbody.velocity = new Vector3(speed,0,0);
	}
	
	void OnCollisionEnter(Collision coll){
		if(coll.gameObject.layer == LayerMask.NameToLayer("invader"))
		{	
			Destroy(coll.gameObject);
		}	
		numberShots = numberShots -1;
		Destroy(gameObject);
	}
}
