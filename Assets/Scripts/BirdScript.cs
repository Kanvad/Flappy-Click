using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    Rigidbody2D _birdRb;
    LogicManagerScript _logic;


    float _moveUp = 20;
    bool _birdIsAlive = true;
    float _yRange = 17;
    // Start is called before the first frame update
    void Start()
    {
        _birdRb = gameObject.GetComponent<Rigidbody2D>();
        _logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _birdIsAlive || Input.GetMouseButtonDown(0) && _birdIsAlive) {
            _birdRb.velocity = Vector2.up * _moveUp;
        }

        if (transform.position.y < -_yRange || transform.position.y > _yRange){
            StopGame();
        }

    }

    private void OnCollisionEnter2D(Collision2D other) {
        StopGame();
    }

    void StopGame() {
        _logic.GameOver();
        _birdIsAlive = false;
    }
}
