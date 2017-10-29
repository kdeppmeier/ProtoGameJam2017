using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnHitDeath : MonoBehaviour
{
    //Script requires Canvas with LevelFailed UI panel
    //and Sound prefab

    public string scene_name = "GameOver";

    private GameObject levelFailedPanel;

    private AudioSource siren;

    void Start()
    {
        siren = GameObject.Find("SirenSound").GetComponent<AudioSource>();
        levelFailedPanel = GameObject.Find("Canvas").transform.Find("LevelFailed").gameObject;
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
