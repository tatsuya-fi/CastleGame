using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NaviMove : MonoBehaviour {
	public GameObject target;

	private NavMeshAgent naviAgent;

	// Use this for initialization
	void Start () {
		naviAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		naviAgent.destination = target.transform.position;
	}
}
