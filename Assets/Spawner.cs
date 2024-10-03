using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime;
    private float timer;

    public GameObject pipes;
    public float pipeHeights;

    private void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipes);
            newPipe.transform.position = transform.position = new Vector3(0, Random.Range(-pipeHeights, pipeHeights), 0);
            Destroy(newPipe, 10f);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
