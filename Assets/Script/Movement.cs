using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Transform feets = null;
    [SerializeField] LayerMask playerMask;


    // [SerializeField] Transform cam = null;
    // [SerializeField] float turnSmoothTime = 0.1f;
    // float turnSmoothVar;

    bool jump;
    float upForce = 5;
    int speed = 3;
    float hMove, vMove;
    Rigidbody component;
    // Start is called before the first frame update

    void Start()
    {
        component = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.Space))
            jump = true;
        hMove = Input.GetAxisRaw("Horizontal");
        vMove = Input.GetAxisRaw("Vertical");
    }
    
    void FixedUpdate() {

        if (jump && Physics.OverlapSphere(feets.position, 0.1f, playerMask).Length != 0) {
            component.AddForce(Vector3.up * upForce, ForceMode.VelocityChange);    
            jump = false;
        }
        component.velocity = new Vector3(hMove*speed, component.velocity.y, vMove*speed);

        // float targetAngle = Mathf.Atan2(component.position.x, component.position.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
        // float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVar, turnSmoothTime);
        
        float targetAngle = Mathf.Atan2(hMove, vMove) * Mathf.Rad2Deg;
        if (hMove != 0 || vMove != 0)
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
    }

}
