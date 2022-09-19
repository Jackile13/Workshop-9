using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    [SerializeField] private float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += new Vector3(0, 0, (this.speed * Time.deltaTime));

        if (transform.localPosition.z > 20) Destroy(gameObject);
    }
}
