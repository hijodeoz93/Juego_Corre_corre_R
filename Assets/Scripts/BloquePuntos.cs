using UnityEngine;
using System.Collections;

public class BloquePuntos : MonoBehaviour {
	private bool Colicion = false;
	private int PuntosGanados=1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D colicion){
		if (!Colicion && colicion.gameObject.tag=="Player") {
			
			GameObject obj= colicion.contacts [0].collider.gameObject;
			if (obj.name == "PataInfDerB" || obj.name == "PataInfIzqB") {
				Colicion = true;
				NotificationCenter.DefaultCenter ().PostNotification (this, "IncrementarPuntos", PuntosGanados);
			}
		}
	}
}
