using UnityEngine;
using System.Collections;

public class Coelho : MonoBehaviour {
    float speed = 0.015f;
    float speed2 = 0.015f;
    GameObject[] coelhos = new GameObject[2];
	// Use this for initialization
	void Start () {
        coelhos[0] = GameObject.Find("Coelho");
        coelhos[1] = GameObject.Find("Coelho2");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Espada.vidascoelho [0] > 0) {
			coelhos [0].transform.Translate (speed, 0, 0);

			if (coelhos [0].transform.position.x >= 64.89f) {
				coelhos [0].transform.localScale = new Vector2 (-0.7157914f, 0.7157914f);
				speed *= -1f;
			} else if (coelhos [0].transform.position.x <= 58.09f) {
				coelhos [0].transform.localScale = new Vector2 (0.7157914f, 0.7157914f);
				speed *= -1f;
			}
		}
		
		
        if(Espada.vidascoelho[1] > 0){
        coelhos[1].transform.Translate(speed2, 0, 0);

        if (coelhos[1].transform.position.x >= 96.4f)
        {
            coelhos[1].transform.localScale = new Vector2(-0.7157914f, 0.7157914f);
            speed2 *= -1f;
        }
        else if (coelhos[1].transform.position.x <= 91.4f)
        {
            coelhos[1].transform.localScale = new Vector2(0.7157914f, 0.7157914f);
            speed2 *= -1f;
        }
        }
	
	}
}
