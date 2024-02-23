using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Launch : MonoBehaviour
{
    private float timeOfSpaceDown = 0;
    private float timeOfTurnKeyDown = 0;
    // private float timeOfLeftDown = 0;

    private float bowlingballForce = 50;
    private Rigidbody rb;

    public static int Score = 0;

    public Text txtScore;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        launchBall();

        handleRotation();

        if (Input.GetKey(KeyCode.R))
        {
            restartGame();
        }

        handleScoreUI();

    }
    void handleRotation()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            timeOfTurnKeyDown += Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            timeOfTurnKeyDown -= Time.deltaTime;
        }

        rb.AddForce(Vector3.right * timeOfTurnKeyDown/10,ForceMode.Impulse);
        transform.Rotate(Vector3.up * timeOfTurnKeyDown / 5f);


    }

    void launchBall()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            timeOfSpaceDown += Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Vector3 bowlingBallForce = Vector3.forward * timeOfSpaceDown * bowlingballForce;

            rb.isKinematic = false;
            rb.AddForce(bowlingBallForce, ForceMode.Impulse);

            timeOfSpaceDown = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Left Gutter" || collision.gameObject.name == "Right Gutter")
        {
            Debug.Log("Gutter! No, but frankly!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Restart")
        {
            resetBall();
        }
    }
    private void restartGame()
    {
        resetBall();
    }


    void resetBall()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = new Vector3(0, 0.5f, 0);
        rb.isKinematic = true;
        timeOfTurnKeyDown = 0;
    }

    void handleScoreUI()
    {
        txtScore.text = "Score: " + Score;
    }


}
