using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class ConditionIsTargetAlive : Decorator
{
	public SharedTransform target;
	public override void OnStart()
	{
		
	}

	public override TaskStatus OnUpdate()
	{
		if(target.Value)
        {
            return TaskStatus.Success;
        }
        return TaskStatus.Failure;
	}
}