namespace ShootEmUp
{
	using UnityEngine;

	public class MoveAgent : MonoBehaviour
	{
		// Const
		const float _minDistance = 0.25f;
		[SerializeField] Ship _ship;

		Vector2 _destination;

		public void Setup(Vector2 destination)
		{
			_destination = destination;
		}

		public bool TryMove()
		{
			var vector = _destination - (Vector2)transform.position;

			if (vector.magnitude <= _minDistance) return false;

			_ship.Move(vector.normalized);
			return true;
		}
	}
}