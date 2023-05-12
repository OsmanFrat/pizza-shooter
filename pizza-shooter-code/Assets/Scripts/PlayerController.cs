using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float range = 15;
    public Transform projectileSpawnPoint;
    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    void Update()
    {   
        // keeping player on the playing field
        if (transform.position.x < -range)
        {
            transform.position = new Vector3(-range, transform.position.y, transform.position.z);
        }
        if (transform.position.x > range)
        {
            transform.position = new Vector3(range, transform.position.y, transform.position.z);
        }
        if(transform.position.z < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
        if(transform.position.z > range)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, range);
        }


        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);
        }
    }
}
