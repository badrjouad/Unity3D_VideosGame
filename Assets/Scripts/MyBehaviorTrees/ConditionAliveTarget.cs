using UnityEngine;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;

public class ConditionAliveTarget : Conditional
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
	/*public override bool CanExecute()
    {
            // CanExecute is called when checking the condition within a while loop so it will be called at least twice. Ensure the conditional task is checked only once
            if (checkConditionalTask) {
                checkConditionalTask = false;
                OnUpdate();
            }

            if (conditionalTaskFailed) {
                return false;
            }
            return executionStatus == TaskStatus.Inactive || executionStatus == TaskStatus.Running;
    }*/
}