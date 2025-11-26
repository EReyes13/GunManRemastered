using UnityEngine;

public class BarrelEx : MonoBehaviour
{
   
    //this variable is in charge of the hitbox in which the bullet collides with it, causing it to explode and acitvate the other rigidbody.
   public BoxCollider2D hitbox;
    //this variable is the explosion radius which will destroy any objects taggeed with enemy that are within its radius. 
   public BoxCollider2D ExRadius;
public float ExTimer = 1;   
public bool Explode = false; 
    void Awake()
    {
        ExRadius.enabled = false;
    }
    void Update()
    {
        if(Explode)
        {
            ExTimer -= Time.deltaTime;
        }
        if(ExTimer <= 0)
        {
            Destroy (gameObject);
        }
    }

    public void Boom()
    {
        hitbox.enabled = false;
            ExRadius.enabled = true;
            Explode = true;
    }

   /* public void OnTriggerEnter2D (Collider2D other)
    {
        if(gameObject.CompareTag("Enemy"))
        {
           Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.InstaDeath();
            }
        }
    }
   /* public void OnCollisionEnter2D (Collision2D other)
    {
        if(gameObject.CompareTag("Bullet"))
        {
            hitbox.enabled = false;
            ExRadius.enabled = true;
            Explode = true;
            Debug.Log("hit Barrel0");
        }
    }

    public void OnTriggerEnter2D (Collider2D other)
    {
        if(gameObject.CompareTag("Enemy"))
        {
           Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.InstaDeath();
            }
        }
    }*/
}
