using UnityEngine;
using System.Collections;

public class ActivarGameOver : MonoBehaviour {
	public GameObject CamaraGameOver;
	public AudioClip  GameOverClip;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this,"PersonajeHaMuerto");
	}
	void PersonajeHaMuerto(){
		GetComponent<AudioSource> ().Stop ();
		GetComponent<AudioSource> ().clip = GameOverClip;
		GetComponent<AudioSource> ().loop = false;
		GetComponent<AudioSource> ().Play ();
		CamaraGameOver.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
