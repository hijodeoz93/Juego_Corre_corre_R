using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {
	public GameObject[] obj;
	public float TiemMin = 1.5f;
	public float TiemMax = 3f;
	public bool fin = false;
	// Use this for initialization
	void Start () {
		
		NotificationCenter.DefaultCenter().AddObserver(this,"JugadorEmpiezaCorrer");
		NotificationCenter.DefaultCenter ().AddObserver (this,"PersonajeHaMuerto");
	}
	void PersonajeHaMuerto(){
		fin = true;

	}

	void JugadorEmpiezaCorrer(Notification notif){
		fin = false;
		Generar(); 
	}
	// Update is called once per frame
	void Update () {
	
	}
	void Generar(){
		if (fin==false) {
			Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
			Invoke ("Generar", Random.Range (TiemMax, TiemMin));
		}
	}
}
