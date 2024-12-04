using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicManagerScript : MonoBehaviour
{
    int _playerScore;
    int _level = 3;
    float _speedLevel = 0;
    public TextMeshProUGUI scoreText;
    public GameObject gameOver;

    public void AddScore(int scoreToAdd) {
        _playerScore += scoreToAdd;
        scoreText.text = _playerScore.ToString();
    }

    public void RestartGame() {
        SceneManager.LoadSceneAsync(0);
    }

    public void GameOver() {
        gameOver.SetActive(true);
    }

    public float SpeedLevel() {
        if (_playerScore == _level) {
            _level += 3;
            _speedLevel++;
            return _speedLevel;
        }
        return _speedLevel;
    }

    public int PlayerScore() {
        return _playerScore;
    }
}
