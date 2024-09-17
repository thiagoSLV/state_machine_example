using Godot;
using System;

public partial class FallState : State
{
	public override void _Ready()
	{
        base._Ready();
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
		move.Fall();
		move.Walk();

		if(parent.Velocity.Y >= 0)
		{
			parent.animation.Play("fall");
		}

		if(Input.IsActionJustPressed("ui_up"))
		{
			fsm.ChangeState("HoverState");
		}

        if(parent.IsOnFloor())
		{
            fsm.ChangeState("IdleState");
		}
    }
}
