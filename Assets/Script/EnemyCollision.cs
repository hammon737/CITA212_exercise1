using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private ParticleSystem hiteffect;

    [SerializeField] private ParticleSystem hiteffect2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hiteffect.transform.position = collision.contacts[0].point;
            hiteffect.Play();
            Debug.Log("Enemy hit by Player!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hiteffect2.transform.position = transform.position;
            hiteffect2.Play();
            Debug.Log("Player went over a trigger!");
        }
    }
}
