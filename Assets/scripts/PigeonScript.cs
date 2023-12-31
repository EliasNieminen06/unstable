using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PigeonScript : MonoBehaviour
{
    public NavMeshAgent agent;
    Vector3 newPos;
    public GameObject gameManager;

    private void Start()
    {
        NewPos();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == newPos)
        {
            NewPos();
        }
        agent.SetDestination(newPos);
    }

    void NewPos()
    {
        float posX = Random.Range(-18, 18);
        float posZ = Random.Range(-18, 18);
        newPos = new Vector3(posX, 0.7730263f, posZ);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "lager")
        {
            gameManager.GetComponent<GameManager>().pigeonDead();
            Destroy(this.gameObject);
        }
    }
}
