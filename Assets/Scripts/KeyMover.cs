using UnityEngine;

public class KeyMover
{
	private static float DEFAULT_MOVE_DISTANCE = 0.5f;
	private static float DEFAULT_MOVE_TIME = 1;

	private KeyMover ()
	{
	}

	public static Vector3 getPositionDelta(Vector3 defaultPosition, float startTime, float currentTime) {
		if (currentTime < startTime || currentTime > startTime + DEFAULT_MOVE_TIME)
			return Vector3.down * 0f;
		float playTime = (currentTime - startTime) / DEFAULT_MOVE_TIME;
		float distance = DEFAULT_MOVE_DISTANCE - Mathf.Abs (DEFAULT_MOVE_DISTANCE - 2 * DEFAULT_MOVE_DISTANCE * playTime / DEFAULT_MOVE_TIME);
		return Vector3.down * distance;
	}
}
