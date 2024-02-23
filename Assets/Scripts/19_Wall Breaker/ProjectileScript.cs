using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ProjectileScript : MonoBehaviour
{
    private float lifeTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime += Time.deltaTime;
        if (lifeTime > 1.5)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("PhysicsCube")){
            Destroy(gameObject);
           // Destroy(collision.gameObject);
            WallBreaker.score += 1;
            Debug.Log("Score: " + WallBreaker.score);
        }

    }
}
