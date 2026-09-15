using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float movespeed = 5f;
    [SerializeField] float rotatespeed = 120f;
    bool hasPackage1 = false;
    bool hasPackage2 = false;

    bool hasPackage = false;

    SpriteRenderer carRender;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        carRender = GetComponent<SpriteRenderer>();
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

  

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package"))
        {
            if (hasPackage == false)
            {
                if (hasPackage1 == false)
                {
                    Debug.Log("Package collected");
                    Destroy(other.gameObject);
                    carRender.color = Color.gold;
                    hasPackage1 = true;
                    hasPackage = true;
                }
            }
        }
        
        if (other.CompareTag("Customer"))
        {
            if (hasPackage1 == true)
            {
                Debug.Log("Package Delivered");
                carRender.color = Color.darkCyan;
                hasPackage1 = false;
                hasPackage = false;
            }
        }

        if (other.CompareTag("Package 2"))
        {
            if (hasPackage == false)
            {
                if (hasPackage2 == false)
                {
                    Debug.Log("Package collected");
                    Destroy(other.gameObject);
                    carRender.color = Color.violet;
                    hasPackage2 = true;
                    hasPackage = true;
                }
            }
        }

        if (other.CompareTag("Customer 2"))
        {
            if (hasPackage2 == true)
            {
                Debug.Log("Package Delivered");
                carRender.color = Color.darkCyan;
                hasPackage2 = false;
                hasPackage = false;
            }
        }



    }

}
