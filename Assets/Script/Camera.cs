using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    float speed = 0.0725f;
    GameObject player;
   public static bool mito = false;
    public static bool collider = true;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Personagem");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
         /* if (collider == true)
            {
                if (player.transform.position.x >= 0f && player.transform.position.x <= 89.87f)
                {
                    mito = true;
                    if (mito == false)
                    {
                        transform.position = new Vector3(player.transform.position.x + 1.55f, 0.63f, -10f);
                    }
                    else if (mito == true)
                    {
                        transform.position = new Vector3(player.transform.position.x, 0.63f, -10f);
                    }
                   // transform.position = new Vector3 (player.transform.position.x, 0.63f, -10f);
                    //(transform.position.x == player.transform.position.x + 0.285f) {
				if (Input.GetKey(KeyCode.RightArrow) == true ||Input.GetAxis("Horizontal") > 0 )
                    {
                        transform.Translate(speed, 0, 0);
                    }

				else if (Input.GetKey(KeyCode.LeftArrow) == true ||Input.GetAxis("Horizontal") < 0 )
                    {

                        transform.Translate(-speed, 0, 0);
                    }
                    //}
                }
                if (transform.position.x <= -1.31f && transform.position.x <= 89.87f)
                {
                    transform.Translate(speed, 0, 0);
                }

                if (transform.position.x >= -1.31f && transform.position.x >= 89.87f)
                {
                    transform.Translate(-speed, 0, 0);
                }

            }*/
        
    }
    void Update() 
    {
    
        

        if (mito == true)
        {
			transform.position = new Vector3(player.transform.position.x, 0.56f, -10f);
        }
        if (collider == true)
        {
            if (player.transform.position.x >= -0.01750001f && player.transform.position.x <= 98.8f)
            {
                mito = true;

                
                // transform.position = new Vector3 (player.transform.position.x, 0.63f, -10f);
                //(transform.position.x == player.transform.position.x + 0.285f) {
                if (Input.GetKey(KeyCode.RightArrow) == true || Input.GetAxis("Horizontal") > 0)
                {
                    transform.Translate(speed, 0, 0);
                }

                else if (Input.GetKey(KeyCode.LeftArrow) == true || Input.GetAxis("Horizontal") < 0)
                {

                    transform.Translate(-speed, 0, 0);
                }
                //}
            }
            else 
            {
                mito = false;
            }

            if (transform.position.x <= -0.01750001f )
            {
                transform.Translate(speed, 0, 0);
                collider = false;
            }

            if ( transform.position.x >= 98.8f)
            {
                transform.Translate(-speed, 0, 0);
            }

        }
    }
}
