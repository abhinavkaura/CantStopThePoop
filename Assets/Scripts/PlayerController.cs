using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

	PlayerStats m_stats;
	Animator m_animator;
	Transform m_playerModel;

	// Use this for initialization
	void Start () 
	{
		m_stats = transform.GetComponent<PlayerStats>();
		m_animator = GetComponentInChildren<Animator>();
		m_playerModel = transform.GetChild(0);

	}
	
	// Update is called once per frame
	void Update () 
	{
		Movement();
	}




	void Movement()
	{
		if(Input.GetKey(KeyCode.Space))
		{
			Debug.Log("POOOOP TIME");
			m_animator.SetInteger("m_animIndex",-1);	

		}
		else if(Input.GetKey(KeyCode.W))
		{
			m_animator.SetInteger("m_animIndex",2);
			transform.position = transform.position + ( new Vector3(1,0,0) * m_stats.m_movementSpeed * Time.deltaTime );
			m_playerModel.forward = new Vector3(1,0,0);
		}
		else if (Input.GetKey(KeyCode.S)) 
		{
			m_animator.SetInteger("m_animIndex",2);
			transform.position = transform.position + ( new Vector3(-1,0,0) * m_stats.m_movementSpeed * Time.deltaTime );
			m_playerModel.forward = new Vector3(-1,0,0);
		}
		else if (Input.GetKey(KeyCode.A)) 
		{
			m_animator.SetInteger("m_animIndex",2);
			transform.position = transform.position + ( new Vector3(0,0,1) * m_stats.m_movementSpeed * Time.deltaTime );
			m_playerModel.forward = new Vector3(0,0,1);
        }
		else if (Input.GetKey(KeyCode.D)) 
		{
			m_animator.SetInteger("m_animIndex",2);
			transform.position = transform.position + ( new Vector3(0,0,-1) * m_stats.m_movementSpeed * Time.deltaTime );
			m_playerModel.forward = new Vector3(0,0,-1);
        }
		else
		{
			Debug.Log("Chilling");
			m_animator.SetInteger("m_animIndex",0);
			
		}
	}
}
