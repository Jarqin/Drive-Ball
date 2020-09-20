using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody rb;
	public float multiplier;
	public Text textScore;
	int score;
    
    void Start()
    {
    	rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
    	float moveX = Input.acceleration.x;
    	float moveY = Input.acceleration.y;
        
        Vector3 posisi = new Vector3(moveX,0f,moveY);

        rb.AddForce(posisi*multiplier);
    }

    void OnTriggerEnter(Collider other)
    {
    	if (other.gameObject.tag == "Kubus")
    	{
    		Destroy(other.gameObject);
    		score++;

    		textScore.text = "Score :" + score;
    	}
	}
}
