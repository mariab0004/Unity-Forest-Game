using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    private void Start()
    {
        speed = 20;
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, -speed, ForceMode.Impulse);
    }

    private void Update()
    {
        if (transform.position.y < -5) 
            SceneManager.LoadScene("Level1");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Vector3 heading = collision.transform.position - transform.position;
            Vector3 direction = -heading / heading.magnitude;
            rb.velocity = direction * speed;
        }
    }
}
