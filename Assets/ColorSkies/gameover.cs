using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform A;
    public Transform B;

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(A);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "A")
        {
            transform.LookAt(B);
        }
        else if (other.gameObject.name == "B")
        {
            transform.LookAt(A);
        }
    }
}
