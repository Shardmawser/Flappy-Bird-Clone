using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Vector2 screenBounds;
    public GameObject ground;
    public Transform resetPos;
    public float offset;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)); 
    }

    // Update is called once per frame
    void Update()
    {
        if(ground.transform.position.x + offset < screenBounds.x * -1)
        {
            ground.transform.position = resetPos.position;
        }
    }
}
