using System;
using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    public class SkidTrail : MonoBehaviour
    {
        [SerializeField] private float m_PersistTime;

        public float PersistTime { get => m_PersistTime; set => m_PersistTime = value; }

        private IEnumerator Start()
        {
			while (true)
            {
                yield return null;

                if (transform.parent.parent == null)
                {
					Destroy(gameObject, PersistTime);
                }
            }
        }
    }
}
