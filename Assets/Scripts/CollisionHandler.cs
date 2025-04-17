using UnityEngine;

public class ColllisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Destroyed !!!");
        Instantiate(destroyedVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
