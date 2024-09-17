using Godot;
using System;

public abstract partial class State : Node 
{
    public Character parent;
    public StateMachine fsm;
    public String animationName;
    public Move move;

    public virtual void Enter()
    {
        parent.animation.Play(animationName);
        SetProcess(true);
        SetPhysicsProcess(true);
    }

    public virtual void Exit()
    {
        parent.animation.Stop();
        SetProcess(false);
        SetPhysicsProcess(false);
    }

    public abstract override void _Process(double delta);
    public abstract override void _PhysicsProcess(double delta);
}