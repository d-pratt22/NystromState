using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class JumpingState : IHeroineState
{
    private readonly Heroine _heroine;
    public float jumpVelocity = 10f;
    private Rigidbody rb;
    public float delay = 1;
    float timer;

    public JumpingState(Heroine heroine)
    {
        _heroine = heroine;
    }

    public void Enter()
    {
        Debug.Log("Enter Jumping");

        rb=_heroine.GetComponent<Rigidbody>();

        Vector3 velocity = rb.linearVelocity;
        velocity.y = jumpVelocity;
        rb.linearVelocity = velocity;
    }


    public void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
           _heroine.SetHeroineState(new DivingState(_heroine));
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            _heroine.SetHeroineState(new FlipState(_heroine));
        }
    }

    public void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            jumpTimer();
        }
    }

    public void jumpTimer()
    {
        if (_heroine.isGrounded)
        {
            _heroine.SetHeroineState(new StandingState(_heroine));
        }
    }
}

