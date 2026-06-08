using UnityEngine;

public class Meteor : MonoBehaviour
{
    float speed = 2.5f;
    float destroy = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
        if(transform.position.y > destroy)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player hit! Game over!");
            Gamemanager.lives = 0f;
            Destroy(gameObject);
        }
    }
}
