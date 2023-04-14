using UnityEngine;
using UnityEngine.Events;
using ProcGenMusic;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("Procedural Music Generator")]
	[Tooltip("Override the config's Group Odds, and hold on the current settings. Prevents the Groups from changing.")]
	public class PMGGroupsOverride : FsmStateAction
	{

		[RequiredField]
		[CheckForComponent(typeof(MusicGenerator))]
		[Tooltip("the target. A MusicGenerator component is required.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("the bool value to set Groups Temporarily Overridden.")]
		public FsmBool overrideGroups;

		public override void Reset()
		{
			overrideGroups = null;
		}

		// Code that runs on entering the state.

		public override void OnEnter()
		{
			MusicGenerator mMusicGenerator = Fsm.GetOwnerDefaultTarget(gameObject).GetComponent<MusicGenerator>();
			if (mMusicGenerator != null)
			{
				mMusicGenerator.GroupsAreTemporarilyOverriden = overrideGroups.Value;

			}
			Finish();
		}


	}

}