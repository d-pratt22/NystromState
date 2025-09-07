using UnityEngine;
using UnityEngine.UIElements;

public class GrowState : IHeroineState
{
    private readonly Heroine _heroine;

    public GrowState(Heroine heroine)
    {
        _heroine = heroine;
    }

    public void Enter()
    {
        Debug.Log("Enter Grow");

        Vector3 scale = _heroine.transform.localScale;
        scale.x = 2f;
        scale.y = 2f;
        scale.z = 2f;
        _heroine.transform.localScale = scale;
    }

    public void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _heroine.SetHeroineState(new StandingState(_heroine));
            Vector3 scale = _heroine.transform.localScale;
            scale.x = 1f;
            scale.y = 1f;
            scale.z = 1f;
            _heroine.transform.localScale = scale;
        }
    }

    public void Update()
    {

    }
}
