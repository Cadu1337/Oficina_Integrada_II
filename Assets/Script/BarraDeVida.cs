using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarraDeVida : MonoBehaviour {
    public static Animator barradevida;
	// Use this for initialization
	void Start () {
        barradevida = gameObject.GetComponent<Animator>();
       
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
