using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {
    public Animator animator;
    private string ENTPN = "Open";
    private string EXTPN = "Close";
	// Use this for initialization
	void Start () {
        animator = animator.GetComponent<Animator>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            animator.SetTrigger(ENTPN);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            animator.SetTrigger(EXTPN);
    }
}
