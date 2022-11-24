using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float streerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * streerSpeed * Time.deltaTime;
        float speed = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, speed, 0);
    }

    void OnCollisionEnter2D(Collider2D other)
    {
        moveSpeed = slowSpeed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
}
