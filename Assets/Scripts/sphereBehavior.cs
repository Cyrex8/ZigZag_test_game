using UnityEngine;
using System.Collections;

public class sphereBehavior : MonoBehaviour
{

    private Rigidbody rb; // Объявление новой переменной Rigidbody
    private bool isMovingLeft = true; // переменная, отражающая условное направление объекта
    [SerializeField]
    private float speed = 150f; // Скорость движения объекта

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Получение доступа к Rigidbody
    }

    void changeDirection()
    {
        if (isMovingLeft)
        {
            isMovingLeft = false;
            transform.rotation = Quaternion.Euler(0, 150, 0);
        }
        else
        {
            isMovingLeft = true;
            transform.rotation = Quaternion.Euler(0, -120, 0);
        }
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            changeDirection();  
        }

        if (isMovingLeft)
        {
            rb.velocity = new Vector3(speed* Time.deltaTime, 0f, 0f);
        }
        else
        {
            rb.velocity = new Vector3(0f, 0f, -speed* Time.deltaTime);
        }

    }

}