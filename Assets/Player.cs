using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed=5f;
     Vector2 rawInput;
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 delta = rawInput * moveSpeed * Time.deltaTime;
        transform.position += delta;
    }

    // Update is called once per frame
    void OnMove(InputValue value)
    {
        rawInput=value.Get<Vector2>();
        Debug.Log(rawInput);
    }
}
