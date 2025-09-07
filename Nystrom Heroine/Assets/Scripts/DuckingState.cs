using UnityEngine;

public class DuckingState : IHeroineState
{
    private readonly Heroine _heroine;

    public DuckingState(Heroine heroine)
    {
        _heroine = heroine;
    }

    public void Enter()
    {
        Debug.Log("Enter Ducking");

        Vector3 scale = _heroine.transform.localScale;
        scale.y = 0.5f; 
        _heroine.transform.localScale = scale;
    }

    public void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            _heroine.SetHeroineState(new StandingState(_heroine));
            Vector3 scale = _heroine.transform.localScale;
            scale.y = 1f;
            _heroine.transform.localScale = scale;
        }
    }

    public void Update()
    {

    }
}
