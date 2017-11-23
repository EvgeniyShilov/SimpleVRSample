using UnityEngine;

public class Mover
{
	private static float DEFAULT_KEY_MOVE_DISTANCE = 0.5f;
	private static float DEFAULT_KEY_MOVE_TIME = 1;
	private static float DEFAULT_BALL_JUMP_HEIGHT = 4;
	private static float DEFAULT_GRAVITY = 9.8f;

	private Mover ()
	{
	}

	public static Vector3 getKeyPositionDelta(Vector3 defaultPosition, float startTime, float currentTime) {
		if (currentTime < startTime || currentTime > startTime + DEFAULT_KEY_MOVE_TIME)
			return Vector3.zero;
		float playTime = (currentTime - startTime) / DEFAULT_KEY_MOVE_TIME;
		float distance = DEFAULT_KEY_MOVE_DISTANCE - Mathf.Abs (DEFAULT_KEY_MOVE_DISTANCE - 2 * DEFAULT_KEY_MOVE_DISTANCE * playTime / DEFAULT_KEY_MOVE_TIME);
		return defaultPosition + Vector3.down * distance;
	}

	public static Vector3 getBallPosition(Vector3 startPosition, Vector3 endPosition, float startTime, float endTime, float currentTime) {
		if (currentTime < startTime || currentTime > endTime)
			return Vector3.zero;
		float T = currentTime - startTime;
		float deltaT = endTime - startTime;
		float deltaX = endPosition.x - startPosition.x;
		float deltaY = endPosition.y - startPosition.y;
		float deltaZ = endPosition.z - startPosition.z;
		float startXVelocity = deltaX / deltaT;
		float startYVelocity = deltaY / deltaT + DEFAULT_GRAVITY * deltaT / 2;
		float startZVelocity = deltaZ / deltaT;
		float X = startXVelocity * T;
		float Y = startYVelocity * T - DEFAULT_GRAVITY * Mathf.Pow (T, 2) / 2;
		float Z = startZVelocity * T;
		return startPosition + new Vector3 (X, Y, Z);
	}
}
