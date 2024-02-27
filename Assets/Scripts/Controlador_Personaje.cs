using UnityEngine;
using System.Collections;

public class Controlador_Personaje : MonoBehaviour {
	public float FuerzaSalto = 100f;
	private bool EnSuelo=true;
	private bool EnSuelo2=true;
	public Transform ComprobadorSuelo;
	private float ComprobadorRadio=0.07f;
	public LayerMask MascaraSuelo;
	private bool DobleSalto = false;
	private Animator animacion;
	private bool correr = false;
	public float velocidad=8f;
	void Awake(){

		animacion = GetComponent<Animator>();
	}
	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate(){
		if (correr) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocidad, GetComponent<Rigidbody2D> ().velocity.y);
		}
		animacion.SetFloat ("VelX", GetComponent<Rigidbody2D>().velocity.x);
		EnSuelo = Physics2D.OverlapCircle (ComprobadorSuelo.position,ComprobadorRadio,MascaraSuelo);
		EnSuelo2 = Physics2D.OverlapCircle (ComprobadorSuelo.position,ComprobadorRadio,MascaraSuelo);
		animacion.SetBool ("Suelo", EnSuelo);
		if (EnSuelo==true || EnSuelo2==true) {
			DobleSalto = false;
		}

	}
	
	// Update is called once per frame
    void Update ()
	{
		if (Input.GetMouseButtonDown(0)) {
			if (correr) {
				//hacemos que el personaje salte si es que puede saltar
				if (EnSuelo || DobleSalto != true) {
					GetComponent<AudioSource> ().Play ();
					GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, FuerzaSalto);
					GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, FuerzaSalto));
					if (DobleSalto == false && EnSuelo != true) {
						DobleSalto = true;
					}
				}
			} else {
				correr = true;
				NotificationCenter.DefaultCenter().PostNotification(this, "JugadorEmpiezaCorrer");
			}
		}
	}
}