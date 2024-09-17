using Godot;
using System;

public partial class WalkState : State
{
    public float horizontalAxis;

    public override void _Ready()
    {
        base._Ready();
        animationName = "walk";
        move = new Move(parent);
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void _Process(double delta)
    {
    }

    public override void _PhysicsProcess(double delta)
    {
        move.Walk();

        if(parent.Velocity == Vector2.Zero)
        {
            fsm.ChangeState("IdleState");
        }

		if(Input.IsActionJustPressed("ui_up"))
        {
            fsm.ChangeState("JumpState");
        }
    }

}