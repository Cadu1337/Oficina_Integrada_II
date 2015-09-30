using UnityEngine;
using System.Collections;

public class AranhaScript : MonoBehaviour {
    float force = 2000f;
    bool Encostarnochão;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
     
        if(Encostarnochão == true){
        rigidbody2D.gravityScale = 1f;
        rigidbody2D.AddForce(Vector2.up * force);
        
        }
        Encostarnochão = false;
	
	}

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Cenario")
        {
            Encostarnochão = true;
        }
		if(other.gameObject.tag == "Municao")
		{
			Destroy(this.gameObject);
			Destroy(other.gameObject);

		}
        
        

    }
}
