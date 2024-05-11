using Godot;
using System;

public partial class goo : CharacterBody2D
{
	//private AnimatedSprite2D _animatedSprite;
	public override void _Ready()
	{
		//_animatedSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		//_animatedSprite.Play("idle");
	}
	public override void _Process(double delta)
	{
		//AnimatedSprite2D sprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		float AMOUNT = 1.8f;
		
		if(Input.IsKeyPressed(Key.A) && Input.IsKeyPressed(Key.W))
		{
			//sprite.FlipH=true;
			//_animatedSprite.Play("running");
			this.Position += new Vector2(-AMOUNT,-AMOUNT).Normalized();
		}
		
		else if(Input.IsKeyPressed(Key.A) && Input.IsKeyPressed(Key.S))
		{
			//sprite.FlipH=true;
			//_animatedSprite.Play("running");
			this.Position += new Vector2(-AMOUNT,AMOUNT).Normalized();
		}
			
		else if(Input.IsKeyPressed(Key.D) && Input.IsKeyPressed(Key.W))
		{
			//sprite.FlipH=false;
			//_animatedSprite.Play("running");
			this.Position += new Vector2(AMOUNT,-AMOUNT).Normalized();
		}
			
		else if(Input.IsKeyPressed(Key.D) && Input.IsKeyPressed(Key.S))
		{
			//sprite.FlipH=false;
			//_animatedSprite.Play("running");
			this.Position += new Vector2(AMOUNT,AMOUNT).Normalized();
		}
			
		else if(Input.IsKeyPressed(Key.W))
		{
			//sprite.FlipH=true;
			//_animatedSprite.Play("running");
			this.Position += new Vector2(0,-AMOUNT);
		}
			
		else if(Input.IsKeyPressed(Key.S))
		{
			//sprite.FlipH=false;
			//_animatedSprite.Play("running");
			this.Position += new Vector2(0,AMOUNT);
		}
			
		else if(Input.IsKeyPressed(Key.D))
		{
			//sprite.FlipH=false;
			//_animatedSprite.Play("running");
			this.Position += new Vector2(AMOUNT,0);
		}
			
		else if(Input.IsKeyPressed(Key.A))
		{
			//sprite.FlipH=true;
			//_animatedSprite.Play("running");
			this.Position += new Vector2(-AMOUNT,0);
		}
		//else
			//_animatedSprite.Play("idle");
		
	}
}
