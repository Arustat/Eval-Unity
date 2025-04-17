using UnityEngine;

public class retry : MonoBehaviour
{
    public void Onclick()
    {
        Debug.Log("Retry");
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
