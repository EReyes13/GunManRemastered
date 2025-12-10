using UnityEngine;

public class NewSpawn : MonoBehaviour
{
    //this variable refers to the enemy prefab that will be spawned
    public GameObject Prefab;
    //this variable is to set the time delay between spawns.
    public float TimeDelay = 5;
    //this array holds the spawn points for the enemies.
    public GameObject[] spawnPoint = new GameObject[4];
    
    void Update()
    {
      //the timedelta time decreases the timedelay variable at a constant rate.
        TimeDelay -= Time.deltaTime;
        //once the timedelay variable is less than or equal to 0.01, 
        // this function is activated and enemy is spawned at a random spawn point
        //  and the timedelay variable is reset to 5 seconds.
        if(TimeDelay <= 0.01)
        {
            //instantiate means that it spawns the prefab which is the enemy at one of the random spawns
            Instantiate(Prefab, spawnPoint[Random.Range(0,3)].transform.position, Quaternion.identity);
            //resets the variable.
            TimeDelay = 5;
        }
    }
}
