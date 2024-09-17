using Godot;
using System;
using System.Collections.Generic;
using System.Transactions;

public partial class StateMachine : Node {
    private Dictionary<string, State> _states;
    public State initialState = new IdleState();
    public State currentState;

    public void Init(Character parent)
    {
        _states = new Dictionary<string, State>();
        foreach(State child in GetChildren())
        {
            _states[child.Name] = child;
            child.parent = parent;
            child.move = new Move(parent);
            child.fsm = this;
            child._Ready();
            child.Exit();
        }

        currentState = _states[initialState.GetType().Name];
        currentState.Enter();
    }

    public void ChangeState(String newState)
    {
        if (!_states.ContainsKey(newState) || _states[newState] == currentState)
        {
            return;
        }
        currentState.Exit();
        currentState = _states[newState];
        currentState.Enter();
        GD.Print(currentState.Name);
    }
}