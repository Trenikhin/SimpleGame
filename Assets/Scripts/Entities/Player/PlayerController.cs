﻿namespace ShootEmUp
{
	using UnityEngine;

	public class PlayerController : MonoBehaviour
	{
		[SerializeField] Ship _playerShip;

		readonly Vector2 _fireDirection = Vector3.up;

		IInputHandler _inputHandler;

		void Start()
		{
			_inputHandler = ServiceLocator.Instance.Get<InputHandler>();

			_inputHandler.OnAttack += Fire;
			_inputHandler.OnMove += _playerShip.Move;
		}

		void OnDestroy()
		{
			_inputHandler.OnAttack -= Fire;
			_inputHandler.OnMove -= _playerShip.Move;
		}

		void Fire()
		{
			_playerShip.Fire(_fireDirection);
		}
	}
}