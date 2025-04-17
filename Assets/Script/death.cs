using UnityEngine;

public class death : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverUI; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            
            gameObject.SetActive(false);

            if (gameOverUI != null)
            {
                gameOverUI.SetActive(true);
            }
        }
    }
}
