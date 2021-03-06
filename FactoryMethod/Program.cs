﻿using System;

namespace FactoryMethod {
	
	/// <summary>
	/// エントリポイント
	/// </summary>
	class Program {

		public static void Main(string[] args) {
			const int randomSeed = 654;
			
			Console.WriteLine("Tetrimino Factory------");
			Execute(new TetriminoFactory(randomSeed));
			
			Console.WriteLine("Debug Tetrimino Factory------");
			Execute(new DebugTetriminoFactory());
		}

		static void Execute(TetriminoFactoryBase factory) {
			new UseCase(factory).Execute();
		}

	}

}