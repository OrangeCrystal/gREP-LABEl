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
		public long Evaluations { get; set; }
		public List<long> Iterations { get; } = new List<long>();

		public Dictionary<AGameAction<TGameState>, long> ActionsPlayed { get; } = new Dictionary<AGameAction<TGameState>, long>();
		public long TotalActionsPlayed { get; set; }

		public bool IsStuck { get; set; }

		public void ToJson(string path)
		{
			JObject jsonRoot = new JObject();
			
			jsonRoot["training_time"] = TrainingTime;
			jsonRoot["evaluation_count"] = Evaluations;
			jsonRoot["iterations"] = new JArray(Iterations);

			JAr