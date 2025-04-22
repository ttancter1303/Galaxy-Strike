using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;
    [SerializeField] int hitPoint = 5;
    private void OnParticleCollision(GameObject other)
    {
        ProcessHitPoint();
    }

    private void ProcessHitPoint()
    {
        hitPoint--;
        if (hitPoint <= 0)
        {
            Instantiate(destroyedVFX, transform.position, Quaternion.identity);
            Destroy(this.gameObject);

        }
    }
}
