using UnityEngine;

public class Enemyy_Combat : MonoBehaviour
{
    public int damage = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<PlayerHealth>().ChangeHealth(-damage);
    }
}
