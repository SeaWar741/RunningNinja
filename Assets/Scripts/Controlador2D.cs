using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador2D : MonoBehaviour
{
    Rigidbody2D rgbody;
    public float vel = 10f;
    public float moveVelocity;
    public bool isWalking;
    public float jumpHeight;
    public bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isWalking = false;

        Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        rgbody.velocity = new Vector2(vel*direction.x,rgbody.velocity.y);

        //Debug.Log("Pos: " + direction.x);

        //derecha
        if(direction.x > 0){
            isWalking = true;
            moveVelocity = vel;
            rgbody.velocity = new Vector2(moveVelocity,0);
            //Debug.Log("Pos: " + direction.x);
        }
        //izquierda
        if(direction.x < 0){
            isWalking = true;
            moveVelocity = -vel;
            rgbody.velocity = new Vector2(moveVelocity,0);
            //Debug.Log("Pos: " + direction.x);
        }
        //jump
        if(direction.y > 0){
            isWalking = false;
            rgbody.velocity = new Vector2(moveVelocity,jumpHeight);
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "sushi"){
            Puntos.numSushi++;
            Destroy(col.gameObject);
        }
        if(col.gameObject.tag == "ramen"){
            Puntos.numSushi+=20;
            Destroy(col.gameObject);
        }
        if(col.gameObject.tag == "onigiri"){
            Puntos.numSushi+=100;
            Destroy(col.gameObject);
        }
        if(col.gameObject.tag == "portal"){
            ManejaEscenas.ChangeScene("Win");
        }
    }

}
