using UnityEngine;

public class ColllisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;
    GameScenceManager scenceManager;
    private void Start()
    {
        Debug.Log("test");
        scenceManager = FindFirstObjectByType<GameScenceManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Destroyed !!!");
        scenceManager.ReloadLevel();
        Instantiate(destroyedVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
