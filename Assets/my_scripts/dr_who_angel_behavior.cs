using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class dr_who_angel_behavior : MonoBehaviour
{
    //escape the maze version
    public GameObject player;
    NavMeshAgent agent;
    Renderer m_Renderer;
    public float speed = 10.0F;
    public Vector3 left_offset;
    public Vector3 right_offset;
    public Light light;
    light_behavior lit;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        lit = light.GetComponent<light_behavior>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (m_Renderer.isVisible && lit.light_on == true && Vector3.Distance(transform.position, player.transform.position) < light.range - 1)
        {
            RaycastHit hit;
            RaycastHit hit_left;
            RaycastHit hit_right;
            
            Vector3 direction = Camera.main.transform.position - transform.position;
            Vector3 direction2 = Camera.main.transform.position - transform.position - left_offset;
            Vector3 direction3 = Camera.main.transform.position - transform.position - right_offset;
            
            
            if (Physics.Raycast(transform.position, direction, out hit))
            {
                if ((hit.collider.tag != "MainCamera" && hit.collider.tag != "Player") && Physics.Raycast(transform.position + left_offset, direction2, 
                    out hit_left) && (hit_left.collider.tag != "MainCamera" && hit_left.collider.tag != "Player") &&
                    Physics.Raycast(transform.position + right_offset, direction3, out hit_right) && (hit_right.collider.tag != "MainCamera" && 
                    hit_right.collider.tag != "Player"))
                {
                    anim.speed = 1;
                    anim.SetTrigger("Walk");
                    Debug.Log("Object is not visible");
                    //transform.LookAt(player.transform.position);
                    agent.SetDestination(player.transform.position);
                }
                else
                {
                    anim.speed = 0;
                    //anim.SetTrigger("idle");
                    Debug.Log("Object is visible");
                    transform.position = transform.position;
                    agent.isStopped = true;
                    agent.ResetPath();
                }
                Debug.DrawRay(transform.position + right_offset, direction3, Color.green);
                Debug.DrawRay(transform.position + left_offset, direction2, Color.green);
                Debug.DrawRay(transform.position, direction, Color.green);
            }
        }
        
        else
        {
            anim.speed = 1;
            anim.SetTrigger("Walk");
            Debug.Log("Object is no longer visible");
            //transform.LookAt(player.transform.position);
            agent.SetDestination(player.transform.position);
        }
    }
}
