using UnityEngine;
using System.Collections;

public class LauncherScript : MonoBehaviour {
	public float force = 75000;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( !animation.isPlaying )
			animation.Play("idle");
	}
	
	void OnTriggerEnter( Collider other )
	{
		if( other.name != "Fighter" )
		{
			other.transform.position = transform.position;
			other.rigidbody.AddForce( 0, force, 0, ForceMode.Impulse );
			
			animation.CrossFade("firing");
		}
	}
}
