using Godot;
using System;

public partial class IdleState : State
{
	
    public override void _Ready()
    {
        base._Ready();
        animationName = "idle";
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
		Vector2 inputDirection = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");

		if(Input.IsActionJustPressed("ui_up") && parent.IsOnFloor())
		{
			fsm.ChangeState("JumpState");
		}

		if(inputDirection.X != 0 && parent.IsOnFloor())
		{
			fsm.ChangeState("WalkState");
		}

		if(!parent.IsOnFloor())
		{
			fsm.ChangeState("FallState");
		}
    }

}
