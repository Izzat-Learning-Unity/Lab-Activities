using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateController : MonoBehaviour
{
    public GameObject enemyToSpawn;
    private GameObject spawnedEnemy;//for the second if statement
    private Color currentColor = new Color(255f, 255f, 25f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (!GameObject.Find(enemyToSpawn.name))// Code doctor recommended 
        {
            Spawn();
        }*/


        if (spawnedEnemy == null)
        {
            Spawn();
        }
        else
        {
            if (Time.time % 0.2 < Time.deltaTime)
            {
                changeColor();
            }
        }
        /*if (Input.GetButtonDown("Jump")) // The one the doctor slashed.
        {
            Spawn();
            
        }*/

    }

    void Spawn()
    {
        spawnedEnemy = Instantiate(enemyToSpawn);
        spawnedEnemy.name = "Enemy";
        spawnedEnemy.transform.position = Vector3.up;
        spawnedEnemy.transform.rotation = Quaternion.Euler(0, 0, 213);
        MeshRenderer renderer = spawnedEnemy.GetComponent<MeshRenderer>();
        renderer.material.color = Color.red;
    }

    private void changeColor()
    {
        float randomR = Random.Range(0, 255);
        currentColor.r = randomR / 255;

        float randomG = Random.Range(0, 255);
        currentColor.g = randomG / 255;


        float randomB = Random.Range(0, 255);
        currentColor.b = randomB / 255;


        MeshRenderer renderer = spawnedEnemy.GetComponent<MeshRenderer>();
        renderer.material.color = Color.red;

        renderer.material.color = currentColor;
    }
}
