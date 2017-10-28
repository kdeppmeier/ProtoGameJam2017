using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnHitDeath : MonoBehaviour {
    public string scene_name = "GameOver";
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(scene_name);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
