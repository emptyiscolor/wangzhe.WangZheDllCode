using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Action_bt_WrapperAI_Monster_BTMonsterRunToInitiative_node64 : Action
	{
		private ObjBehaviMode method_p0;

		public Action_bt_WrapperAI_Monster_BTMonsterRunToInitiative_node64()
		{
			this.method_p0 = ObjBehaviMode.Attack_Path;
		}

		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((ObjAgent)pAgent).SetCurBehavior(this.method_p0);
			return EBTStatus.BT_SUCCESS;
		}
	}
}
