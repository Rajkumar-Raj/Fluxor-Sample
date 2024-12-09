using Fluxor;

namespace BlazorApp8
{
    //public record CounterState(int Count);

    //public static class CounterStateExtensions
    //{
    //    public static CounterState InitialState => new CounterState(Count: 0);
    //}

    [FeatureState]
    public class CounterState
    {
        public int Count { get; set; }

        // Default constructor
        public CounterState() { }

        // Constructor with initial value
        public CounterState(int count)
        {
            Count = count;
        }

        // Provide an initial state
        public static CounterState InitialState => new CounterState(count: 0);
    }

    public class IncrementCounterAction { }
    public class DecrementCounterAction { }

    public static class CounterReducers
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action)
        {
            return new CounterState(state.Count + 1);
        }

        [ReducerMethod]
        public static CounterState ReduceDecrementCounterAction(CounterState state, DecrementCounterAction action)
        {
            return new CounterState(state.Count - 1);
        }
    }

    //public class CounterEffects
    //{
    //    [EffectMethod]
    //    public async Task HandleIncrementAction(IncrementCounterAction action, IDispatcher dispatcher)
    //    {
    //        // Simulate side effect (e.g., logging or API call)
    //        await Task.Delay(500);
    //        Console.WriteLine("Increment action handled by effect.");
    //    }
    //}


}
