using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLocation : MonoBehaviour
{

    public GameObject person;
    private Vector3 lastPosition;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != lastPosition && rb.velocity == Vector3.zero){
            StartCoroutine(ChangePositionCoroutine());
        }
    }

    IEnumerator ChangePositionCoroutine()
    {
        lastPosition = transform.position;
        yield return new WaitForSeconds(4);
        person.transform.position = new Vector3(lastPosition.x+.8f, person.transform.position.y, lastPosition.z-.8f);

    }
}
