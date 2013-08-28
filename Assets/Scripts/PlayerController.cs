using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed = 5.0f;
	
	public Transform shotPosition;
	public GameObject Shot;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey ("left")){
			rigidbody.velocity = new Vector3(0,0,-speed);
		}else if(Input.GetKey ("right")){
			rigidbody.velocity = new Vector3(0,0,speed);
		}else{
			rigidbody.velocity= new Vector3(0,0,0);
		}
		
		if(Input.GetKeyDown ("space") && PlayerShot.numberShots < PlayerShot.maxShots){
			GameObject.Instantiate (Shot,shotPosition.position,shotPosition.rotation);
			PlayerShot.numberShots = PlayerShot.numberShots +1;
		}
	}
}
