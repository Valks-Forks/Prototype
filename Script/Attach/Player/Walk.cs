using Component.StateMachine;
using Component.Animation;

public partial class Walk : ControllableState{
	private CharacterBody2D Player;
	public override void _EnterTree(){
		base._EnterTree();
		Player = GetOwnerOrNull<CharacterBody2D>();
		Frame = new FrameComponent(8, 1, 8.5);
		}
	public override void UpdateCondition(double delta){
		Condition = (!Player.Velocity.IsEqualApprox(Vector2.Zero));
		}
	}
