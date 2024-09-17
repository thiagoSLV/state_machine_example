using Godot;

public partial class Move 
{
    private Character character;

    public Move(Character character)
    {
        this.character = character;
    }

    public void Walk()
    {
        float horizontalAxis = Input.GetAxis("ui_left", "ui_right");
        Vector2 velocity = new Vector2(horizontalAxis * 75f, character.Velocity.Y);
        
        if(horizontalAxis != 0)
        {
            character.animation.FlipH = horizontalAxis < 1;
        }

        character.Velocity = velocity;
        character.MoveAndSlide();
    }

    public void Jump()
    {
        Vector2 velocity = new Vector2(character.Velocity.X, character.JumpVelocity);
        character.Velocity = velocity;
        character.MoveAndSlide();
    }

    public void Fall()
    {
        Vector2 velocity = new Vector2(character.Velocity.X, character.Velocity.Y);
		velocity.Y += 10 ;
		character.Velocity = velocity;
		character.MoveAndSlide();
    }

    public void Hover()
    {
        Vector2 velocity = new Vector2(character.Velocity.X, 0);
		velocity.Y += 6;
		character.Velocity = velocity;
		character.MoveAndSlide();
    }
}