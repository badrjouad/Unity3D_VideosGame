using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class GetDroneInOrder : Action
{
    public SharedTransform target;

	Drone[] drones;

	IArmyElement m_ArmyElement;

	Transform dMin = null;
    float minDist = Mathf.Infinity;

	public override void OnAwake()
	{
		m_ArmyElement =(IArmyElement) GetComponent(typeof(IArmyElement));
	}

	public override TaskStatus OnUpdate()
	{
		if (!m_ArmyElement.ArmyManager) return TaskStatus.Running;
		ArmyManagerRed armyRed = m_ArmyElement.ArmyManager as ArmyManagerRed;

		drones = armyRed.GetAllEnemiesOfType<Drone>(true).ToArray();
		Vector3 currentPos = transform.position;

		foreach (Drone d in drones)
		{
            /*
			if (!(t && t.transform)) continue;
			float dist = Vector3.Distance(t.transform.position, currentPos);
			if (dist < minDist)
			{
				tMin = t.transform;
				minDist = dist;
			}
			else tMin = t.transform;
            */
            dMin = d.transform;
		}

		
		/*target.Value = tMin;*/
        target.Value = dMin;
		if (target.Value != null) return TaskStatus.Success;
		else return TaskStatus.Failure;
		
	}
}
