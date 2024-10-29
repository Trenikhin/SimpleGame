namespace ShootEmUp
{
	using System;
	using UnityEngine;

	public sealed class LevelBackground : MonoBehaviour
	{
		[SerializeField] Params m_params;
		float endPositionY;
		float movingSpeedY;

		Transform myTransform;
		float positionX;
		float positionZ;
		float startPositionY;

		void Awake()
		{
			startPositionY = m_params.m_startPositionY;
			endPositionY = m_params.m_endPositionY;
			movingSpeedY = m_params.m_movingSpeedY;
			myTransform = transform;
			var position = myTransform.position;
			positionX = position.x;
			positionZ = position.z;
		}

		void FixedUpdate()
		{
			if (myTransform.position.y <= endPositionY)
				myTransform.position = new Vector3(
					positionX,
					startPositionY,
					positionZ
				);

			myTransform.position -= new Vector3(
				positionX,
				movingSpeedY * Time.fixedDeltaTime,
				positionZ
			);
		}

		[Serializable]
		public sealed class Params
		{
			[SerializeField] public float m_startPositionY;
			[SerializeField] public float m_endPositionY;
			[SerializeField] public float m_movingSpeedY;
		}
	}
}