using UnityEngine;
using UnityEngine.SceneManagement;
public class CoinScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public string sceneName;
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Debug.Log("Scene is " + SceneManager.GetActiveScene().name);
            if(sceneName == "Level 3")
            {
                SceneManager.LoadScene("Level 4");
                
            }
            else
            {
                SceneManager.LoadScene("Level 3");
            }
        }
    }
}
