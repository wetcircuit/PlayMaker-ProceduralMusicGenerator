using UnityEngine;
using UnityEngine.Events;
using ProcGenMusic;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("Procedural Music Generator")]
	[Tooltip("Set the Group's isPlaying bool. Use with PMG Override Groups action or the groups will re-roll according to the config")]
	public class PMGGroupSetIsPlaying : FsmStateAction
	{

		[RequiredField]
		[CheckForComponent(typeof(MusicGenerator))]
		[Tooltip("the target. A MusicGenerator component is required.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("Index of the group.")]
		public FsmInt groupIndex;

		[RequiredField]
		[Tooltip("bool is true when the Group is playing.")]
		public FsmBool groupIsPlaying;

		
		public override void Reset()
		{
			groupIndex = null;
			groupIsPlaying = null;
		}


		// Code that runs on entering the state.

		public override void OnEnter()
		{
			MusicGenerator mMusicGenerator = Fsm.GetOwnerDefaultTarget(gameObject).GetComponent<MusicGenerator>();
			if ( mMusicGenerator != null )
			{
				var instrument = mMusicGenerator.InstrumentSet;
				 instrument.OverrideGroupIsPlaying(groupIndex.Value, groupIsPlaying.Value);
			}

			Finish();
		}




	}

}