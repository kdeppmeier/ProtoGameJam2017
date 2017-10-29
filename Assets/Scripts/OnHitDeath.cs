using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnHitDeath : MonoBehaviour {
    public string scene_name = "GameOver";

    public GameObject levelFailedPanel;

    private AudioSource siren;

    void Start()
    {
        siren = GameObject.Find("SirenSound").GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //SceneManager.LoadScene(scene_name);
            levelFailedPanel.SetActive(true);
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = false;
            siren.Play();
        }
    }
}
