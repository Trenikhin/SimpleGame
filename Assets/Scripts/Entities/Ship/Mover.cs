namespace ShootEmUp
{
	using UnityEngine;

	public class Mover : MonoBehaviour
	{
		[SerializeField] Rigidbody2D _rigidbody;

		[SerializeField] float _speed;


		public void Move(Vector2 moveDirection)
		{
			var moveStep = moveDirection * Time.fixedDeltaTime * _speed;
			var targetPosition = _rigidbody.position + moveStep;
			_rigidbody.MovePosition(targetPosition);
		}
	}
}