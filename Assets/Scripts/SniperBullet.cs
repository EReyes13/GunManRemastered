using UnityEngine;

public class SniperBullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter2D( Collider2D other)
    {

            if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage();
            }
        }

            if(other.CompareTag("Terrain"))
            {
                Debug.Log("BounceBack");
            }
    }
}
