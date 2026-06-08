using UnityEngine;

public class Life1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.lives == 1f)
        {
            Destroy(gameObject);
        }
    }
}
