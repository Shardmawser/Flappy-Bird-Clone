using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    Vector2 screenBounds;
    public Transform resetPos;
    public float offset;


    public float groundSpeed;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x + offset < screenBounds.x * -1)
        {
            transform.position = resetPos.position;
        }

        Move();
    }

    
    void Move()
    {
        transform.Translate(transform.right * groundSpeed * -1 * Time.deltaTime);
    }
}
