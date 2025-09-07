using UnityEngine;

public class StandingState : IHeroineState
{
    private readonly Heroine _heroine;

    public StandingState(Heroine heroine)
    {
        _heroine = heroine;
    }

    public void Enter()
    {
        Debug.Log("Enter Standing");


    }

    public void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _heroine.SetHeroineState(new JumpingState(_heroine));
        }

        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            _heroine.SetHeroineState(new DuckingState(_heroine));
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            _heroine.SetHeroineState(new ChameleonState(_heroine));
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _heroine.SetHeroineState(new GrowState(_heroine));
        }
    }

    public void Update()
    {

    }
}
