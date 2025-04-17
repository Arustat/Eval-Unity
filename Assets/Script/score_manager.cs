using TMPro;
using UnityEngine;

public class score_manager : MonoBehaviour
{
    public static score_manager instance;

    private int _score = 0;

    [SerializeField]
    private TextMeshProUGUI _scoreText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddPoints(int points)
    {
        _score += points;
        _scoreText.text = "Score: " + _score;
    }
}
