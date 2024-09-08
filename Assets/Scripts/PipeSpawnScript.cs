using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipes;

    float _timer = 0;
    float _spawnRate = 3.5f;
    float _heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
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

    void SpawnPipe()
    {

        float _lowestPoint = transform.position.y - _heightOffset;
        float _highestPoint = transform.position.y + _heightOffset;

        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(_lowestPoint, _highestPoint), 0), transform.rotation);

    }
}
