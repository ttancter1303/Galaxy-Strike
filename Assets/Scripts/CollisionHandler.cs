using UnityEngine;

public class ColllisionHandler : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit: "+other.gameObject.name);
    }
}
