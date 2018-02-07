using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour {
    public GameObject asteroide;
    public float spawnTime = 4f;
    public float elapsedTime = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     if(GameController.instance.gamOver == false){
            if (elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime;
            }
            else
            {
                float random = Random.Range(-3f, 3f);
                Instantiate(asteroide, new Vector3(random, 5, 0), Quaternion.identity);
                elapsedTime = 0;
            }
        }
        }
}
