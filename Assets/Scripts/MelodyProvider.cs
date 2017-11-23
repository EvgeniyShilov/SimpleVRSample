using System;

public class MelodyProvider
{
	private MelodyProvider ()
	{
	}

	public static Note[] notes1 = new Note[] {
		new Note('d', 0),
		new Note('a', 2),
		new Note('d', 3),
		new Note('b', 4),
		new Note('a', 6),
		new Note('g', 7),
		new Note('a', 8),
		new Note('g', 10),
		new Note('a', 11),
		new Note('b', 12),
		new Note('a', 14),
		new Note('g', 15),
		new Note('d', 16)
	};

	public static Note[] notes2 = new Note[] {
		new Note('g', 0),
		new Note('e', 2),
		new Note('e', 3),
		new Note('g', 4),
		new Note('e', 6),
		new Note('e', 7),
		new Note('g', 8),
		new Note('f', 9),
		new Note('e', 10),
		new Note('d', 11),
		new Note('c', 12),
		new Note('d', 13),
		new Note('e', 14),
		new Note('f', 15),
		new Note('g', 16),
	};

	public class Note {

		public char key;
		public float time;

		public Note(char key, float time) {
			this.key = key;
			this.time = time;
		}
	}
}
