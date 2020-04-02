﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodAI : MobAI
{
	public List<string> GenericSounds = new List<string>();

	/// <summary>
	/// Changes Time that a sound has the chance to play
	/// WARNING, decreasing this time will decrease performance.
	/// </summary>
	public int PlaySoundTime = 3;

	private bool soundplaying = false;

	void Start()
    {
		PlaySound();
    }

	void PlaySound()
	{
		if (!IsDead && !IsUnconscious && GenericSounds.Count > 0)
		{
			var num = Random.Range(1, 3);
			if (num == 1)
			{
				SoundManager.PlayNetworkedAtPos(GenericSounds[Random.Range(0, GenericSounds.Count - 1)], transform.position, Random.Range(0.9f, 1.1f), sourceObj: gameObject);
			}
			Invoke("PlaySound", PlaySoundTime);
		}
	}
}
