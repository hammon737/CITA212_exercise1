using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float movespeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Movement script started");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movespeed * Time.deltaTime, 0f, 0f);
    }
}
