using UnityEngine;
using UnityEngine.Events;
using ProcGenMusic;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("Procedural Music Generator")]
	[Tooltip("Get the Group's isPlaying bool.")]
	public class PMGGroupGetIsPlaying : FsmStateAction
	{

		[RequiredField]
		[CheckForComponent(typeof(MusicGenerator))]
		[Tooltip("the target. A MusicGenerator component is required.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("bool is true when Group 1 is playing.")]
		[UIHint(UIHint.Variable)]
		public FsmBool group1IsPlaying;

		[RequiredField]
		[Tooltip("bool is true when Group 2 is playing.")]
		[UIHint(UIHint.Variable)]
		public FsmBool group2IsPlaying;

		[RequiredField]
		[Tooltip("bool is true when Group 3 is playing.")]
		[UIHint(UIHint.Variable)]
		public FsmBool group3IsPlaying;

		[RequiredField]
		[Tooltip("bool is true when Group 4 is playing.")]
		[UIHint(UIHint.Variable)]
		public FsmBool group4IsPlaying;

        	[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		
		public override void Reset()
		{
			group4IsPlaying = null;
			group1IsPlaying = null;
			group2IsPlaying = null;
			group3IsPlaying = null;
			everyFrame = false;
		}


		// Code that runs on entering the state.

		public override void OnEnter()
		{
			MusicGenerator mMusicGenerator = Fsm.GetOwnerDefaultTarget(gameObject).GetComponent<MusicGenerator>();
			if ( mMusicGenerator != null )
			{
					group1IsPlaying.Value = mMusicGenerator.InstrumentSet.GroupIsPlaying[0] ? true : false;
					group2IsPlaying.Value = mMusicGenerator.InstrumentSet.GroupIsPlaying[1] ? true : false;
					group3IsPlaying.Value = mMusicGenerator.InstrumentSet.GroupIsPlaying[2] ? true : false;
					group4IsPlaying.Value = mMusicGenerator.InstrumentSet.GroupIsPlaying[3] ? true : false;

			}

			if (!everyFrame)
			{
				Finish();
			}
		}


		public override void OnUpdate()
		{
			MusicGenerator mMusicGenerator = Fsm.GetOwnerDefaultTarget(gameObject).GetComponent<MusicGenerator>();
			if ( mMusicGenerator != null )
			{
					group1IsPlaying.Value = mMusicGenerator.InstrumentSet.GroupIsPlaying[0] ? true : false;
					group2IsPlaying.Value = mMusicGenerator.InstrumentSet.GroupIsPlaying[1] ? true : false;
					group3IsPlaying.Value = mMusicGenerator.InstrumentSet.GroupIsPlaying[2] ? true : false;
					group4IsPlaying.Value = mMusicGenerator.InstrumentSet.GroupIsPlaying[3] ? true : false;

			}


		}


	}
}