using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeMove : MonoBehaviour
{//Instancia del Input System
    InputController inputController;

    //Animator
    Animator animator;

    //Character Controller
    CharacterController cc;

    float speed;
    Vector3 dir;

    bool running = false;

    //Variable del Joystick Izquierdo
    Vector2 stickL;

    //Variables de los trigger
    float triggerR;
    float triggerL;

    //Dash 
    float _dashTime = 2f;
    float _dashSpeed = 20f;

    //Estados
    bool corriendo = false;
    bool strafing = false;

    //Cámaras
    [SerializeField] GameObject VCam;
    [SerializeField] GameObject FreeLook;



    private void Awake()
    {
        inputController = new InputController();

        //Botón de correr
        inputController.Moverse.Correr.performed += ctx => { corriendo = true; };
        inputController.Moverse.Correr.canceled += ctx => { corriendo = false; };

       
        //Stick para caminar
        inputController.Moverse.Caminar.performed += ctx => stickL = ctx.ReadValue<Vector2>();
        inputController.Moverse.Caminar.canceled += _ => stickL = Vector2.zero;

        //Triggers giro
        inputController.Moverse.GiroIzq.performed += ctx => triggerL = ctx.ReadValue<float>();
        inputController.Moverse.GiroIzq.canceled += ctx => triggerL = 0f;

        inputController.Moverse.GiroDer.performed += ctx => triggerR = ctx.ReadValue<float>();
        inputController.Moverse.GiroDer.canceled += ctx => triggerR = 0f;

        //Dash
        //inputController.Moverse.Dash.performed += _ => Dash();

    }


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        cc = GetComponent<CharacterController>();

        //Activo las cámaras
        VCam.SetActive(false);
        FreeLook.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        DetectarMovimientoLateral();

        //Aplicar movimiento en función del estado
        if (corriendo && stickL.y > 0)
        {
            Correr();

        }
        else if (strafing && stickL.y == 0)
        {
            MovimientoLateral();

        }
        else
        {
            Caminar();
        }

        //Giro
        transform.Rotate(new Vector3(0f, stickL.x * 0.8f, 0f));

    }

    void DetectarMovimientoLateral()
    {
        //Detectar si me muevo lateralmente
        if (triggerL != 0 || triggerR != 0)
        {
            strafing = true;
        }
        else
        {
            strafing = false;
        }
    }

    void Correr()
    {
        animator.SetBool("Run", true);
        animator.SetBool("Strafing", false);
        speed = 8f;
        dir = transform.TransformDirection(Vector3.forward);
        cc.SimpleMove(dir * speed * stickL.y);
    }

    void MovimientoLateral()
    {
        float strafe = triggerR - triggerL;
        animator.SetBool("Strafing", true);
        animator.SetBool("Run", false);
        animator.SetFloat("Strafe", strafe);
        dir = transform.TransformDirection(Vector3.right);
        speed = 1.8f;

        cc.SimpleMove(dir * strafe * speed);
    }

    void Caminar()
    {
        animator.SetBool("Strafing", false);
        animator.SetBool("Run", false);
        animator.SetFloat("Walk", stickL.y);

        if (stickL.y > 0)
        {
            speed = 2.2f;
        }
        else
        {
            speed = 0.8f;
        }

        dir = transform.TransformDirection(Vector3.forward);

        cc.SimpleMove(dir * speed * stickL.y);
    }



    //Dash
    void Dash()
    {
        StartCoroutine(DashCoroutine());
    }

    private IEnumerator DashCoroutine()
    {
        float startTime = Time.time; // need to remember this to know how long to dash
        while (Time.time < startTime + _dashTime)
        {
            transform.Translate(transform.forward * _dashSpeed * Time.deltaTime);
            // or controller.Move(...), dunno about that script
            yield return null; // this will make Unity stop here and continue next frame
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        // Si el objeto colisionado no tiene RigidBody
        if (body == null)
        {
            return;
        }
        //Aquí comprobaríamos el tag del objeto colisionado
        if (hit.gameObject.CompareTag("TagBuscado"))
        {
        }
    }

    private void OnEnable()
    {
        inputController.Enable();
    }

    private void OnDisable()
    {
        inputController.Disable();
    }


   
}
