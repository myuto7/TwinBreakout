using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver_r : MonoBehaviour
{
    public Text gameOverMessage;
    public Text retryMessage;
    bool isGameOver = false;

    void Update() {
        if (isGameOver && Input.GetButtonDown("Submit")) 
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("PlayScene");
        }
    }

    void OnCollisionEnter(Collision collision) {
        gameOverMessage.text = "1P WIN!";
        retryMessage.text = "Retry -> Enter";
        Destroy(collision.gameObject);
        isGameOver = true;
        Time.timeScale = 0;
    }
}
