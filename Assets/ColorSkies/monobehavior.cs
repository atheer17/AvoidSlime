using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float degreePerSecond = 2f;
    public float speed = 1.0f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalinput, 0f, verticalinput);
        rb.velocity = movement * speed;

    }
}