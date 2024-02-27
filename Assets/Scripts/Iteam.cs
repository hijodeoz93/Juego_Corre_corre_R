using UnityEngine;
using System.Collections;

public class Iteam : MonoBehaviour {
	private int PuntuacionFruta=5;
	public AudioClip iteamS;
	public float itemVol=1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") {
			NotificationCenter.DefaultCenter ().PostNotification (this, "IncrementarPuntos", PuntuacionFruta);
			AudioSource.PlayClipAtPoint (iteamS, Camera.main.transform.position, itemVol);
		}
		Destroy (gameObject);
	}
}
