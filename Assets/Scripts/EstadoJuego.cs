using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class EstadoJuego : MonoBehaviour {

	public static EstadoJuego estado;
	private String NombreArchivo;
	public int PuntuacionMaxima = 0;
	void Awake(){
		//Debug.Log (Application.persistentDataPath);
		NombreArchivo = Application.persistentDataPath+"/datos.dat";
		if (estado == null) {
			estado = this;
			DontDestroyOnLoad (gameObject);
		} else if (estado!=this){
			Destroy (gameObject);
			
		}
	}
	// Use this for initialization
	void Start () {
		Cargar ();
	}
	
	// Update is called once per frame
	void Update () {

	}
	void Cargar(){
		if (File.Exists (NombreArchivo)) {
			BinaryFormatter bn = new BinaryFormatter ();
			FileStream file = File.Open (NombreArchivo, FileMode.Open);

			GuardarDatos datos = (GuardarDatos)bn.Deserialize (file);
			PuntuacionMaxima = datos.puntuacionMaxima;
			file.Close ();
		} else {
			PuntuacionMaxima = 0;
		}

	}
	public void Guardar(){

		BinaryFormatter bn = new BinaryFormatter ();
		FileStream file =File.Create (NombreArchivo);
		GuardarDatos datos = new GuardarDatos ();
		datos.puntuacionMaxima = PuntuacionMaxima;
		bn.Serialize (file, datos);

		file.Close ();

	}


[Serializable]
class GuardarDatos{

	public int puntuacionMaxima;
	}
}
