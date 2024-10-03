using UnityEngine;

public class ScoringZone : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.Score++;
    }
}
