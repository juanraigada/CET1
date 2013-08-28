using UnityEngine;
using System.Collections;

public class InvaderGroupController : MonoBehaviour {
	
	static bool right = true;
	static bool down = false;
	float currentX = 0;
	public float speed = 2.0f;
	public float step = 5.0f;
	
	// Use this for initialization
	void Start () {
		currentX = transform.position.x;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		GameObject[] invaders = GameObject.FindGameObjectsWithTag ("invader");
		foreach(GameObject invader in invaders){
			if(down){
				if(transform.position.x > currentX + step){
					transform.position = new Vector3(currentX + step,0,transform.position.z);
					rigidbody.velocity = new Vector3(0,0,0);
					invader.rigidbody.velocity = new Vector3(0,0,0);
					down = false;
					currentX = currentX + step;
				}else{
					rigidbody.velocity = new Vector3(speed,0,0);
					invader.rigidbody.velocity = new Vector3(speed,0,0);
				}
			}else{
				if(right){ 
					invader.rigidbody.velocity = new Vector3(0,0,speed);
				}else{
					invader.rigidbody.velocity = new Vector3(0,0,-speed);
				}
			}
		}
	}
	
	public static void ChangeDirection(){
		down = true;
		if(right){
			right = false;
		}else{
			right = true;
		}
	}
}
