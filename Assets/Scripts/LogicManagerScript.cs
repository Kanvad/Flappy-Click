using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    int _playerScore;
    public Text scoreText;
    public GameObject gameOver;

    public void AddScore(int scoreToAdd) {
        _playerScore += scoreToAdd;
        scoreText.text = _playerScore.ToString();
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver() {
        gameOver.SetActive(true);
    }
}
