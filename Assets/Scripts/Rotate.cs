using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    [HideInInspector] public Vector3 rotation;
    [SerializeField] private Vector3 rotation2;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate ( rotation );
	}
}
