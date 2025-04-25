using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;
    [SerializeField] int hitPoint = 5;
    [SerializeField] int score = 10;
    ScoreBoard scoreBoard;

    private void Start()
    {
        Debug.Log("Start");
        scoreBoard = FindFirstObjectByType<ScoreBoard>();
    }
    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        hitPoint--;
        if (hitPoint <= 0)
        {
            scoreBoard.IncreaseScore(score);
            Instantiate(destroyedVFX, transform.position, Quaternion.identity);
            Destroy(this.gameObject);

        }
    }
}
