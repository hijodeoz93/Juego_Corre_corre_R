using UnityEngine;
using System.Collections;

public class SeguirCamara : MonoBehaviour {

	public Transform jugador;
	public float Separacion = 6f;
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (jugador.position.x+Separacion, transform.position.y, transform.position.z);
	}
}
