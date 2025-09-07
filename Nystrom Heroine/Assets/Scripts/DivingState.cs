using UnityEngine;

public class DivingState : IHeroineState
{
    private readonly Heroine _heroine;
    public float diveVelocity = -18f;
    private Rigidbody rb;

    public DivingState (Heroine heroine)
    {
        _heroine = heroine;
    } 

    public void Enter()
    {
        Debug.Log("Enter Diving");

        rb = _heroine.GetComponent<Rigidbody>();

        Vector3 velocity = rb.linearVelocity;
        velocity.y = diveVelocity;
        rb.linearVelocity = velocity;
    }

    public void HandleInput()
    {

    }

    public void Update()
    {
        if (_heroine.isGrounded)
        {
            _heroine.SetHeroineState(new StandingState(_heroine));
        }
    }
}
