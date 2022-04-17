using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{

    SpriteRenderer sr;
    [SerializeField] float speed = 8f;

    // Start is called before the first frame update
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            moveVector.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveVector.x = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveVector.y = -1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            moveVector.y = 1;
        }
        if (moveVector != Vector3.zero)
        {
            transform.position += moveVector.normalized * Time.deltaTime * speed;
            transform.rotation = Quaternion.Euler(0, 0, Vector3.SignedAngle(new Vector3(1, 0), moveVector, new Vector3(0, 0, 1)));
            //transform.rotation = Quaternion.Euler(0, 0, Vector3.Angle(new Vector3(1, 0), moveVector));
        }
    }
}
