using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed;
	public GameObject speaker, interacaoicon;
	public bool s = false;
    
    void Start(){
        //rb2d = GetComponent<Rigidbody2D> ();
        if(s == true && Input.GetKeyDown("space")){ speaker.SetActive(true); }
    }
	
	void OnTriggerEnter2D(Collider2D c){
		if(c.gameObject.name == "NPC"){
			interacaoicon.SetActive(true);
			s = true;
		} 
	}

	void OnTriggerExit2D(Collider2D c){
		if(c.gameObject.name == "NPC") { interacaoicon.SetActive(false); } 
	}
	
    void FixedUpdate(){
    	Movimentação();
    }
	
    public void Movimentação(){
    	transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        transform.Translate(Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime);
	}
}
