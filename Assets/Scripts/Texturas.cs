using UnityEngine;
using System.Collections;

public class Texturas : MonoBehaviour {
	public float velocidad=0f;
	private bool EnMovimiento = false;
	private float TiempoInicio = 0f;
	public bool IniciarEnMovimiento = false;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this,"JugadorEmpiezaCorrer");
		NotificationCenter.DefaultCenter ().AddObserver (this,"PersonajeHaMuerto");
		if (IniciarEnMovimiento) {
			JugadorEmpiezaCorrer ();
		}
	}
	void PersonajeHaMuerto(){

		EnMovimiento = false;
	}
	void JugadorEmpiezaCorrer(){
		EnMovimiento = true;
		TiempoInicio = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (EnMovimiento) {
			GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (((Time.time - TiempoInicio)* velocidad)%1, 0);
		}
	}
}
