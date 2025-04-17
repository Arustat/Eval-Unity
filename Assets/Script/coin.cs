using UnityEngine;

public class coin : MonoBehaviour
{
    [SerializeField]
    private int points = 10; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            
            score_manager.instance.AddPoints(points);
            sound_manager.instance.PlayCoin();
            Destroy(gameObject);
        }
    }
}
