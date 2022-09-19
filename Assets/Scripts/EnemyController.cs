using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [SerializeField] private int health = 2;
    [SerializeField] private GameObject enemyParticlesTemplate;
    [SerializeField] private GameObject bulletParticlesTemplate;

    private int initialHealth = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Bullet(Clone)")
        {
            Destroy(other.gameObject);
            var bulletParticles = Instantiate(bulletParticlesTemplate);
            bulletParticles.transform.position = other.ClosestPoint(gameObject.transform.position);

            Destroy(bulletParticles, 1.0f);
        }

        //Debug.Log("Before Health = " + health--);
        //Debug.Log("After Health = " + health);

        if (0 == --health)
        {
            Destroy(gameObject);
            var enemyParticles = Instantiate(enemyParticlesTemplate);
            enemyParticles.transform.position = other.ClosestPoint(gameObject.transform.position);

            Destroy(enemyParticles, 1.0f);
        }
        else if (health == initialHealth / 2)
        {
            var material = GetComponent<Renderer>().material;
            material.color = (new Color(material.color.r / 2, material.color.g / 2, material.color.b / 2, material.color.a));
        }
    }
}
