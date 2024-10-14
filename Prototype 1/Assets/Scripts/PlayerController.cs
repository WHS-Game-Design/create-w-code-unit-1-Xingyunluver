using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputZ = Input.GetAxis("Vertical");
        float inputX = Input.GetAxis("Horizontal");

    transform.Translate(inputZ * speed * Vector3.forward * Time.deltaTime);
    transform.Rotate(inputX * speed * 10 * Vector3.up * Time.deltaTime);
    }
}
