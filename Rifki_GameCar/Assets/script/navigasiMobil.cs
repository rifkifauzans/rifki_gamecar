using UnityEngine;
using System.Collections;

public class navigasiMobil : MonoBehaviour {
	
	public float mobilSpeed;
	public float maxPos = 2.2f;
	Vector3 position;
	// Use this for initialization
	void Start () {
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		position.x += Input.GetAxis ("Horizontal") * mobilSpeed * Time.deltaTime;
		position.x = Mathf.Clamp (position.x, -maxPos, maxPos);
		transform.position = position;
	}

	void OnCollisionEnter2D(Collision2D col){
		Destroy (gameObject);
			print ("Game Over");


	}
}
