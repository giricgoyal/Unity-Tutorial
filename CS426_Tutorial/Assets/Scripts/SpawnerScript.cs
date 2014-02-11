using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
	public GameObject obj;
	
	public float timer;
	public float timeDelay = 5;
	
	// Use this for initialization
	void Start () {
		timer = timeDelay;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		
		if( timer <= 0 )
		{
			Instantiate(obj, new Vector3( Random.Range(-100,100), 5, Random.Range(-100,100) ), transform.rotation );
			timer = timeDelay;
		}
	}
}
