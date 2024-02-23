using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreaker : MonoBehaviour
{
    public Transform projectileSpawner;
    public GameObject projectile;
    private float shotForce = 1000f;
    private float moveSpeed = 10f;
    private float rotationSpeed = 100f;

    private float horizontalInput;
    private float verticalInput;

    private float mouseXInput;
    //private float mouseYInput;

    public static float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score:" + score);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        mouseXInput = Input.GetAxis("Mouse X");
        //mouseYInput = Input.GetAxis("Mouse Y");

        if (Time.time < 0.5f)
        {
            mouseXInput = 0;
            //mouseYInput = 0;
        }

        transform.Translate(new Vector3(horizontalInput*moveSpeed*Time.deltaTime
            ,verticalInput*moveSpeed*Time.deltaTime
            ,0));

        transform.Rotate(0
            , mouseXInput * Time.deltaTime* rotationSpeed
            , 0);

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject shotProjectile = Instantiate(projectile, projectileSpawner.position,Quaternion.identity);
            Rigidbody projectileRB = shotProjectile.GetComponent<Rigidbody>();

            projectileRB.AddForce(transform.forward * shotForce);

        }
    }
}
