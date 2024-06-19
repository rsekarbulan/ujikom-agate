using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public GameObject foodPrefab;

    public float speed;
    private Vector3 movement = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        ThrowFood();
    }

    private void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        movement.x = horizontal;

        controller.Move(movement * speed * Time.deltaTime);
    }

    private void ThrowFood()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject foodInstance = Instantiate(foodPrefab);

            Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f);
            foodInstance.transform.position = spawnPos;

            Destroy(foodInstance, 3f);
        }
    }
}
