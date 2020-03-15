using System;
using System.Collections.Generic;

namespace Interpreter {

	/// <summary>
	/// キャラクター全体管理
	/// </summary>
	class CharacterManager {

		readonly Dictionary<string, Character> characters = new Dictionary<string, Character>();


		public void Create(string id, string texture) {
			if (characters.TryGetValue(id, out var _)) {
				throw new InvalidOperationException($"Character is already created. Id = {id}");
			}

			characters.Add(id, new Character());

			Console.WriteLine($"Character was created. Id = {id}, Texture = {texture}");
		}

		public void Move(string id, int x, int y) {
			if (!characters.TryGetValue(id, out var character)) {
				throw new InvalidOperationException($"Character is not created. Id = {id}");
			}

			character.X = x;
			character.Y = y;

			Console.WriteLine($"Character moved. Id = {id}, X = {x}, Y = {y}");
		}

	}

}