using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float movespeed = 5f;
    [SerializeField] float rotatespeed = 120f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, 0f, rotatespeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f, 0f, -rotatespeed * Time.deltaTime);

        }
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 Move = new Vector3(x, y, 0f);
        transform.Translate(Move * movespeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Happened"+collision.gameObject.name);
        if (collision.collider.CompareTag("obstacle"))
        {
            Debug.Log("obstacle collission" + collision.gameObject.name);
        }
    }
}
