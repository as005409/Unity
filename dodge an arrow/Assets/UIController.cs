using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public bool gameOver = false;

    public float score = 0f;

    public Text ScoreText;
    public Text GameOverText;
    public Button restart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString("F2");

        if (gameOver)
        {
            GameOverText.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
        }
        else {
            score += Time.deltaTime;
        }
    }

    public void gameOverTrue() {
        gameOver = true;
    }

    public void restartGame()
    {
        SceneManager.LoadScene(1);
    }
}
