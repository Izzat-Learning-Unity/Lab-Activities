using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour
{
    public Button btnPlay;
    // Start is called before the first frame update
    void Start()
    {
        btnPlay.onClick.AddListener(switchToPlayScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void switchToPlayScene()
    {
        SceneManager.LoadScene("Bowling");
    }
}
