using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {
    public float speed = 2f;
    Rigidbody2D rb;
    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float movX = Input.acceleration.x;
        rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
