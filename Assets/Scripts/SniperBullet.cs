using UnityEngine;

public class SniperBullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public Rigidbody2D rb;
    public float Velx;
    public float Vely;
    public int bounce = 0;
    
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
                if(rb.linearVelocityX != 0)
                {
                Velx = rb.linearVelocity.x;
                Debug.Log("BounceBack");
                rb.linearVelocity = new Vector2(-Velx, rb.linearVelocity.y);
                bounce ++;
                }
                else if (rb.linearVelocityY != 0)
            {
                
                Vely = rb.linearVelocity.y;
                Debug.Log("BounceBack");
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, -Vely);
                bounce ++;
            }
            if(bounce == 3)
            {
                Destroy(gameObject);
            }
            }
    }
}
