using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform (26)"))
        {
            Debug.Log("Game Over");
        }
        if (collision.gameObject.CompareTag("Platform (27)"))
        {
            Debug.Log("Game Over");
        }
        if (collision.gameObject.CompareTag("Platform (28)"))
        {
            Debug.Log("Game Over");
        }
    }
}
