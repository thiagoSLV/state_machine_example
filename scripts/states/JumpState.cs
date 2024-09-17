using Godot;
using System;

public partial class JumpState : State
{

	public override void _Ready()
	{
        base._Ready();
        animationName = "jump";
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
		move.Jump();

		if(Input.IsActionJustPressed("ui_up"))
		{
			fsm.ChangeState("HoverState");
		}
		else 
		{
			fsm.ChangeState("FallState");
		}
    }
}
