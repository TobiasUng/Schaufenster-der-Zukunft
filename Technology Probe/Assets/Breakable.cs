using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Breakable : MonoBehaviour
{
    public GameObject fruitSlicedPrefab;

    public float startForce = 15f;

    [SerializeField] private UnityEvent sliceEvent;


    Rigidbody2D rb;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Blade")
        {
            //Vector3 direction = (col.transform.position - transform.position).normalized;

            //Quaternion rotation = Quaternion.LookRotation(direction);

            sliceEvent.Invoke();

            GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, transform.rotation);
            Destroy(slicedFruit, 5f);



            Destroy(gameObject);

            
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
        rb.AddTorque(3, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
