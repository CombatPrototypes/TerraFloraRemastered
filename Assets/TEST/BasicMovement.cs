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

    public bool attacking = false;
    bool attack1 = false;

    void Awake()
    {
        controller = new BaseController();
    }

    // Update is called once per frame
    void Update()
    {
        attacking = anim.GetBool("Attacking");

        if (!attacking)
        {
            MovePlayer(_moveVector);
        }





        AnimHandler(_moveVector, attack1);
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

        //if (attack1)
        //{
        //    PlayAttack1Animation();
        //}

    }





    private void OnEnable()
    {
        controller.Enable();

        controller.Traversal.WASD.performed += WASD_performed;
        controller.Combat.Attack.started += Attack_started;
        controller.Combat.Attack.performed += Attack_performed;
        controller.Combat.Attack.canceled += Attack_canceled;

        controller.Combat.HeavyAttack.started += HeavyAttack_started;
        controller.Combat.HeavyAttack.performed += HeavyAttack_performed;
        controller.Combat.HeavyAttack.canceled += HeavyAttack_canceled;

        controller.Combat.ThirdAttack.started += ThirdAttack_started;
        controller.Combat.ThirdAttack.performed += ThirdAttack_performed;
        controller.Combat.ThirdAttack.canceled += ThirdAttack_canceled;

    }

    

    private void OnDisable()
    {
        controller.Traversal.WASD.performed -= WASD_performed;

        controller.Combat.Attack.started -= Attack_started;
        controller.Combat.Attack.performed -= Attack_performed;
        controller.Combat.Attack.canceled -= Attack_canceled;

        controller.Combat.HeavyAttack.started -= HeavyAttack_started;
        controller.Combat.HeavyAttack.performed -= HeavyAttack_performed;
        controller.Combat.HeavyAttack.canceled -= HeavyAttack_canceled;

        controller.Combat.ThirdAttack.started -= ThirdAttack_started;
        controller.Combat.ThirdAttack.performed -= ThirdAttack_performed;
        controller.Combat.ThirdAttack.canceled -= ThirdAttack_canceled;

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


    private void Attack_started(InputAction.CallbackContext ctx)
    {
        if(ctx.interaction is TapInteraction)
        {
            if(!attacking)
            {
                anim.SetTrigger("StartAttackOne");
                Debug.Log("Tap Started");
                anim.SetBool("Attacking", true);
            }
            else
            {
                Debug.Log("Already attacking");
            }
        }
    }


    private void Attack_performed(InputAction.CallbackContext ctx)
    {
        if (ctx.interaction is HoldInteraction)
        {
            Debug.Log("Hold performed");
            anim.SetBool("AttackOnePerformed", true);
        }
        else if (ctx.interaction is TapInteraction)
        {
            Debug.Log("Tap performed");
            anim.SetBool("AttackOnePerformed", true);
        }
    }


    private void Attack_canceled(InputAction.CallbackContext ctx)
    {
        if (ctx.interaction is HoldInteraction)
        {
            anim.SetBool("AttackOnePerformed", true);
        }
        else if(ctx.interaction is TapInteraction)
        { 
            anim.SetBool("AttackOneCharging", true);
        }
    }

    private void HeavyAttack_started(InputAction.CallbackContext ctx)
    {
        if (ctx.interaction is TapInteraction)
        {
            if (!attacking)
            {
                anim.SetTrigger("StartAttackTwo");
                Debug.Log("Tap Started");
                anim.SetBool("Attacking", true);
            }
            else
            {
                Debug.Log("Already attacking");
            }
        }
    }


    private void HeavyAttack_performed(InputAction.CallbackContext ctx)
    {
        if (ctx.interaction is HoldInteraction)
        {
            Debug.Log("Hold performed");
            anim.SetBool("AttackTwoPerformed", true);
        }
        else if (ctx.interaction is TapInteraction)
        {
            Debug.Log("Tap performed");
            anim.SetBool("AttackTwoPerformed", true);
        }
    }


    private void HeavyAttack_canceled(InputAction.CallbackContext ctx)
    {
        if (ctx.interaction is HoldInteraction)
        {
            anim.SetBool("AttackTwoPerformed", true);
        }
        else if (ctx.interaction is TapInteraction)
        {
            anim.SetBool("AttackTwoCharging", true);
        }
    }

    private void ThirdAttack_started(InputAction.CallbackContext ctx)
    {
        if (ctx.interaction is TapInteraction)
        {
            if (!attacking)
            {
                anim.SetTrigger("StartAttackThree");
                Debug.Log("Tap Started");
                anim.SetBool("Attacking", true);
            }
            else
            {
                Debug.Log("Already attacking");
            }
        }
    }

    private void ThirdAttack_performed(InputAction.CallbackContext ctx)
    {
        if (ctx.interaction is HoldInteraction)
        {
            Debug.Log("Hold performed");
            anim.SetBool("AttackThreePerformed", true);
        }
        else if (ctx.interaction is TapInteraction)
        {
            Debug.Log("Tap performed");
            anim.SetBool("AttackThreePerformed", true);
        }
    }

    private void ThirdAttack_canceled(InputAction.CallbackContext ctx)
    {
    
        if (ctx.interaction is HoldInteraction)
        {
            anim.SetBool("AttackThreePerformed", true);
        }
        else if (ctx.interaction is TapInteraction)
        {
            anim.SetBool("AttackThreeCharging", true);
        }
    }



}
