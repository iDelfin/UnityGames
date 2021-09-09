using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float speed = 5.0f;
    CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Debug.Log("Horizontal: " + horizontal);

        cc.Move(new Vector2(horizontal*speed, 0) * Time.deltaTime);
        cc.Move(new Vector2(0, vertical*speed) * Time.deltaTime);
    }
}
