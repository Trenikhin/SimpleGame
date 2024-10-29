namespace ShootEmUp
{
	using Configs;
	using UnityEngine;
	
	public class Gun : MonoBehaviour
	{
		[SerializeField] Transform    _firePoint;
		[SerializeField] GunConfig    _config;
 		
		BulletManager _bulletManager;
		
		void Start()
		{
			_bulletManager = ServiceLocator.Instance.Get<BulletManager>();
		}

		public void Fire( Vector2 direction )
		{
			_bulletManager.SpawnBullet(
				_firePoint.position,
				_config.Color,
				(int) _config.Layer,
				_config.Damage,
				direction * _config.Velocity
			);
		}
	}
}