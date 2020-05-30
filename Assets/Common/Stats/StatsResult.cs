using System.Collections.Generic;
using System.IO;
using Common.Core;
using Newtonsoft.Json.Linq;

namespace Common.Benchmark
{
	public class StatsResult<TGameState>
	where TGameState : IGameState<TGameState>
	{
		public double TrainingTime { get; set; }
		public long Evaluations { get;