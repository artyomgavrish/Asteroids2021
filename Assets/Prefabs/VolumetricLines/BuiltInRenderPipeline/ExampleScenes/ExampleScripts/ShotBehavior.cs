using UnityEngine;
using System.Collections;

public class ShotBehavior : MonoBehaviour {

	public float speed;


	void Update () {
		transform.position += transform.forward * Time.deltaTime * speed;
	}
	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}


}
