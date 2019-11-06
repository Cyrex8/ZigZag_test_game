using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class playerFalls : MonoBehaviour
{
    public GameObject canvas;
    private Rigidbody rb;
    int points=0;
    Text myText;
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }
    void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Coin")
            Destroy(other.gameObject);
        points++;
        Debug.Log("очки= " + points);
    }

    void Update()
    {
        
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 5f) && hit.transform.gameObject.tag == "Ground")
        {
            rb.useGravity = false;
        }
        else
        {

            rb.useGravity = true;
            canvas.SetActive(true);

        }
        myText = GameObject.Find("Score").GetComponent<Text>();
       
        myText.text = "Score: " + points.ToString();

    }

    }

