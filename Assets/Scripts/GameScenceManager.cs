using UnityEngine;
using UnityEngine.SceneManagement;


public class GameScenceManager : MonoBehaviour
{
    public void ReloadLevel()
    {
        int currentScenceIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScenceIndex);
        Debug.Log("Load scence");
    }
}
