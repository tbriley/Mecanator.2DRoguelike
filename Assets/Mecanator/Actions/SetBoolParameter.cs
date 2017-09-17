﻿using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

[System.Serializable]
public class SetBoolParameter : StateMachineAction
{
	public string ParameterName;

    public bool Value;

	private int ParameterHash;

    private void OnEnable()
    {
       ParameterHash = Animator.StringToHash(ParameterName); 
    }

    public override void Execute (StateMachineActionObject smao)
	{
        smao.Animator.SetBool (ParameterHash, Value);
	}
}
