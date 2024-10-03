using UnityEngine;

public class Spawner : MonoBehaviour
{

    private readonly GameObject pipes;

    private readonly float pipeHeights = 5F;
    private readonly float maxTimeSeconds = 2F;

    private float timer;

    private void Update()
    {
        if (timer > maxTimeSeconds)
        {
            GameObject newPipe = Instantiate(pipes);
            newPipe.transform.position = transform.position = new Vector3(0, Random.Range(-pipeHeights, pipeHeights), 0);
            Destroy(newPipe, 10f);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
