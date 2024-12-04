using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    float _speedMove = 5;
    float _deadZone = -45;
    float _speedLevel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _speedLevel = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>().SpeedLevel();

        transform.position += (Vector3.left * (_speedMove + _speedLevel)) * Time.deltaTime;
        if (transform.position.x < _deadZone)
        {
            Destroy(gameObject);
        }
    }
}
