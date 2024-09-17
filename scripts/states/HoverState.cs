using Godot;
using System;

public partial class HoverState : State
{
	
	public override void _Ready()
	{
        base._Ready();
		animationName = "hover";
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
		move.Hover();
		move.Walk();

		if(!Input.IsActionPressed("ui_up"))
		{
            fsm.ChangeState("FallState");
		}

        if(parent.IsOnFloor()){
            fsm.ChangeState("IdleState");
		}
    }
}
