using Godot;
using System;

public partial class Character : CharacterBody2D
{
	private StateMachine stateMachine;
	public AnimatedSprite2D animation;
	public float JumpVelocity = -400.0f;

	public override void _Ready()
	{
		animation = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		stateMachine = GetNode<StateMachine>("StateMachine");
		stateMachine.Init(this);
	}
}
