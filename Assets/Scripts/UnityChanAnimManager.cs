using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnityChanAnimManager : MonoBehaviour {
	NavMeshAgent navMeshAgent;
	Animator animator;

	// Use this for initialization
	void Start () {
		navMeshAgent = this.GetComponent<NavMeshAgent> ();
		animator = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(navMeshAgent.velocity.magnitude > 0.1f){
			animator.SetFloat("speed", navMeshAgent.velocity.magnitude);
			transform.LookAt(transform.position + navMeshAgent.velocity);
		} else {
			animator.SetFloat("speed", 0f);
		}
	}
}
