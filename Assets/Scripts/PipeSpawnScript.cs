using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipes;

    float _timer = 0;
    float _spawnRate = 3.8f;
    float _heightOffset = 10;
    int _playerScore;
    int _limitScore = 5;
    private bool _birdIsAlive;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        _birdIsAlive = GameObject.Find("Bird").GetComponent<BirdScript>().BirdIsAlive();
        _playerScore = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>().PlayerScore();

        if (_playerScore == _limitScore)
        {
            _limitScore += 5;
            if (_spawnRate > 0)
            {
                _spawnRate -= 0.2f;
            }
        }

        if (_birdIsAlive)
        {
            if (_timer < _spawnRate)
            {
                _timer += Time.deltaTime;
            }
            else
            {
                SpawnPipe();
                _timer = 0;
            }
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - _heightOffset;
        float highestPoint = transform.position.y + _heightOffset;

        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0),
            transform.rotation);
    }
}