using NUnit.Framework.Internal;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChameleonState : IHeroineState
{
    private readonly Heroine _heroine;
    Renderer test;
    public ChameleonState(Heroine heroine)
    {
        _heroine = heroine;
    }

    public void Enter()
    {
        Debug.Log("Enter Chameleon");

        test = _heroine.GetComponent<MeshRenderer>();
        test.enabled = false;
    }

    public void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _heroine.SetHeroineState(new DivingState(_heroine));
            test.enabled = true;
        }
    }

    public void Update()
    {

    }
}
