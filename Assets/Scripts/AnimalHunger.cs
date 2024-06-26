using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalHunger : MonoBehaviour
{
    public float hunger;
    private GameObject player;
    private Stats stats;
    public GameObject particlesPrefab;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        stats = player.GetComponent<Stats>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    { 
        DecreaseHunger();
        Debug.Log("aa");   
    }

    private void DecreaseHunger()
    {
        hunger -= 25;

        if (hunger <= 0)
        {
            Destroy(gameObject);
            PlayParticles();
            stats.AddScore(score);
        }
    }

    private void PlayParticles()
    {
        GameObject particlesInstance = Instantiate(particlesPrefab);
        particlesInstance.transform.position = transform.position;
        
        ParticleSystem parts = particlesInstance.GetComponent<ParticleSystem>();
        parts.Play();

        Destroy(particlesInstance, 2f);
    }
}
