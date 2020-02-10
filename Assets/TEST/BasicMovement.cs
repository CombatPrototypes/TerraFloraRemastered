using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class BasicMovement : MonoBehaviour
{
    public Animator anim;
    public Transform playerObjTransform;
    BaseController controller;


    public Vector2 _moveVector = Vector2.zero;
    public float _moveSpeed = 0.5f;

    bool attacking = false;

    void Awake()
    {
        controller = new BaseController();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Working");
        if (!attacking)
        {
            MovePlayer(_moveVector);
        }

        AnimHandler(_moveVector, attacking);
    }



    void MovePlayer(Vector2 vector)
    {
        if(vector == Vector2.zero)
        {
            return;
        }

        Vector3 currentPos = Vector3.zero;
        Vector3 targetPos = Vector3.zero;

        currentPos = playerObjTransform.position;

        targetPos = currentPos;

        targetPos.x += (vector.x * _moveSpeed);

        if(vector.x < 0)
        {
            playerObjTransform.localScale = new Vector3(-1, 1, 1);
        }
        else if(vector.x > 0)
        {
            playerObjTransform.localScale = new Vector3(1, 1, 1);
        }


        playerObjTransform.SetPositionAndRotation(targetPos, Quaternion.identity);

    }





    void AnimHandler(Vector2 vector, bool attack)
    {
        if(vector.x != 0)
        {
            anim.SetBool("Moving", true);
        }
        else
        {
            anim.SetBool("Moving", false);
        }

        if (attack)
        {
            anim.SetTrigger("BasicAttack");
            attacking = false;
        }
    }





    private void OnEnable()
    {
        controller.Enable();

        controller.Traversal.WASD.performed += WASD_performed;
        controller.Combat.Attack.performed += Attack_performed;
    }


    private void OnDisable()
    {
        controller.Traversal.WASD.performed -= WASD_performed;
        controller.Combat.Attack.performed -= Attack_performed;

        controller.Disable();
    }

    private void WASD_performed(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
    {
        if(ctx.interaction is HoldInteraction)
        {
            _moveVector = ctx.ReadValue<Vector2>();
        }
        else if(ctx.interaction is PressInteraction)
        {
            _moveVector = Vector2.zero;
        }
    }
    
    
    
    private void Attack_performed(InputAction.CallbackContext obj)
    {
        attacking = true;
    }
}
