using UnityEngine;

public class NewSpawn : MonoBehaviour
{
    public GameObject Prefab;
    public float TimeDelay = 5;
    public GameObject[] spawnPoint = new GameObject[4];
    
    void Update()
    {
        TimeDelay -= time.deltaTime;
        if(TimeDelay <= 0.01)
        {
            Instantiate(Prefab, spawnPoint[Random.Range(0,3)]);
        }
    }
}
