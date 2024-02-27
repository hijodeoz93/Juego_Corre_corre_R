using UnityEngine;
using System.Collections;

public class ActualizarValores : MonoBehaviour {
	public TextMesh Puntos;
	public TextMesh record;
	public Puntacion puntuacion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnEnable(){
		if (EstadoJuego.estado != null) {
			Puntos.text = puntuacion.puntuacion.ToString ();
			record.text = EstadoJuego.estado.PuntuacionMaxima.ToString ();
		} 
	}
}
