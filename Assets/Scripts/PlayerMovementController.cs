using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {

    [SerializeField]
    KeyCode ForewardKey;

    [SerializeField]
    KeyCode BackwardKey;

    [SerializeField]
    KeyCode RightKey;

    [SerializeField]
    KeyCode LeftKey;

    [SerializeField]
    KeyCode JumpKey;

    // Start is called before the first frame update
    private void Start() {
        Vector3 Forces = GetComponent<Rigidbody>.forces;
    }

    // Update is called once per frame
    private void Update() {
        
    }
}
