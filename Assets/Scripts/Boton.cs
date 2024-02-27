using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Boton : MonoBehaviour {
	public string Esena = "1";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		Camera.main.GetComponent<AudioSource> ().Stop ();
		GetComponent<AudioSource> ().Play ();
		Invoke("CargarEsena",GetComponent<AudioSource>().clip.length);

	}
	void CargarEsena(){
		SceneManager.LoadScene (Esena);
	}
}
