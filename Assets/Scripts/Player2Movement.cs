using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{

    SpriteRenderer sr;
    [SerializeField] float speed = 8f;
    //public GameObject fire;
    //bool isFireGrowing = true;

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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveVector.x = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveVector.x = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveVector.y = -1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveVector.y = 1;
        }
        if (moveVector != Vector3.zero)
        {
            transform.position += moveVector.normalized * Time.deltaTime * speed;
            transform.rotation = Quaternion.Euler(0, 0, Vector3.SignedAngle(new Vector3(1, 0), moveVector, new Vector3(0,0,1)));
            //if (fire.transform.position.x > -0.3)
            //{
            //    isFireGrowing = true;
            //}
            //else if ( fire.transform.position.x < -0.7)
            //{
            //    isFireGrowing = false;
            //}
            //if (isFireGrowing)
            //{
            //    fire.transform.position += new Vector3(0.1f * Time.deltaTime, 0, 0);
            //}
            //else
            //{
            //    fire.transform.position += new Vector3(-0.1f * Time.deltaTime, 0, 0);
            //}
        }
    }
}
