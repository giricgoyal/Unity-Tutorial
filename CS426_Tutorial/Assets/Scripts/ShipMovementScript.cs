using UnityEngine;
using System.Collections;

public class ShipMovementScript : MonoBehaviour {
	public float speed = 25;
	public float turnSpeed = 100;
	
	public GameObject projectile;
	public float force = 75;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate( Input.GetAxis("Vertical") * Time.deltaTime * Vector3.down * speed );
		transform.Rotate( 0, 0, Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed );
		
		if( Input.GetButtonDown("Fire1") )
		{
			GameObject proj = Instantiate( projectile, transform.position, transform.rotation ) as GameObject;
			proj.rigidbody.AddRelativeForce( Vector3.down * force, ForceMode.Impulse );
		}

	}
}
