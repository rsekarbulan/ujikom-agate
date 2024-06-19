using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalNew : MonoBehaviour
{
    public Transform target;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Target").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += -Vector3.forward * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            Destroy(gameObject);
        }
    }
}
