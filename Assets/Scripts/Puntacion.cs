using UnityEngine;
using System.Collections;

public class Puntacion : MonoBehaviour {
	public int puntuacion = 0;
	public TextMesh Marcador;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "IncrementarPuntos");
		NotificationCenter.DefaultCenter ().AddObserver (this,"PersonajeHaMuerto");

		ActualizarMarcador ();
	}
	void PersonajeHaMuerto(){

		if (puntuacion > EstadoJuego.estado.PuntuacionMaxima) {
			//Debug.Log ("Puntuacion Superada, puntos: " + puntuacion + "Record: " + EstadoJuego.estado.PuntuacionMaxima);
			EstadoJuego.estado.PuntuacionMaxima = puntuacion;
			EstadoJuego.estado.Guardar ();
			
		} //else {
			//Debug.Log ("Puntuacion No superada, Puntos: " + puntuacion + " Record: " + EstadoJuego.estado.PuntuacionMaxima);
		//}
	}
	void IncrementarPuntos(Notification notificacion){
		int PuntosIncrementar =(int) notificacion.data;
		puntuacion += PuntosIncrementar;
		ActualizarMarcador ();

	}

	void ActualizarMarcador(){
		Marcador.text = puntuacion.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
