using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidPipe : MonoBehaviour
{
    LogicManagerScript _logic;

    void Start()
    {
        _logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            _logic.AddScore(1);
        }
    }
}
