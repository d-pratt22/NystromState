using UnityEngine;

public class FlipState : IHeroineState
{
    private readonly Heroine _heroine;
    public FlipState(Heroine heroine)
    {
        _heroine = heroine;
    }

    public void Enter()
    {
        Debug.Log("Enter Flip");

        Rigidbody rb = _heroine.GetComponent<Rigidbody>();
        rb.angularVelocity = new Vector3(10f, 0f, 0f);
    }

    public void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            _heroine.SetHeroineState(new DivingState(_heroine));
        }
    }

    public void Update()
    {
        if (_heroine.isGrounded)
        {
            _heroine.SetHeroineState(new StandingState(_heroine));
        }
    }
}
