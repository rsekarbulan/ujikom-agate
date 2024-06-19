using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public GameObject foodPrefab;
    public GameObject foodAudio;
    private Animator anim;

    public float speed;
    private Vector3 movement = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Animation();
        ThrowFood();
    }

    private void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        movement.x = horizontal;

        controller.Move(movement * speed * Time.deltaTime);
    }

    private void Animation()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetInteger("move", 1);
        }
        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetInteger("move", 2);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetTrigger("Throw");
        }
    }

    private void ThrowFood()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FoodAudio();

            GameObject foodInstance = Instantiate(foodPrefab);

            Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z + 1f);
            foodInstance.transform.position = spawnPos;

            Destroy(foodInstance, 3f);
        }
    }

    private void FoodAudio()
    {
        GameObject foodAudioInstance = Instantiate(foodAudio);
        AudioSource source = foodAudioInstance.GetComponent<AudioSource>();
        source.Play();

        Destroy(foodAudioInstance, 2f);
    }
}
